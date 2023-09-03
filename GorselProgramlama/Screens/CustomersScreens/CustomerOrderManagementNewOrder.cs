using GorselProgramlama.Models;
using GorselProgramlama.Screens.HomeAndLoginScreens;
using GorselProgramlama.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlama.Screens.CustomersScreens
{
    public partial class CustomerOrderManagementNewOrder : UserControl
    {
        public Products SelectedProduct = new Products();
        public string SelectedCategory;
        public void RefreshTable()
        {
            var category = ProductService.GetCategoryWithName(SelectedCategory);
            var products = ProductService.GetProductWithCategoryName(category.CategoryName);
            dataGridView1.DataSource = products;
        }
        public CustomerOrderManagementNewOrder()
        {
            InitializeComponent();
            foreach(var item in ProductService.GetCategoryNames())
            {
                comboBox1.Items.Add(item);
            }
            using(var db = new DbService())
            {
                var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                foreach(var storage in storageList)
                {
                    comboBox2.Items.Add(storage.StorageName);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            RefreshTable();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedProduct.Id = (int)selectedRow.Cells[4].Value;
            SelectedProduct.ProductSupplier = selectedRow.Cells[1].Value.ToString();
            SelectedProduct.ProductName = selectedRow.Cells[0].Value.ToString();
            SelectedProduct.ProductCost = (double)selectedRow.Cells[2].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newOrder = new SupplyHistory();
            if(SelectedProduct!=null && numericUpDown2.Value!=0)
            {
                newOrder.Supplier = SelectedProduct.ProductSupplier;
                newOrder.Product = SelectedProduct.ProductName;
                newOrder.Customer = StaticEntities.ActiveUsername;
                newOrder.ProductTotal = (int)numericUpDown2.Value;
                newOrder.IsCompleted= 0;
                if((int)numericUpDown2.Value >= 100)
                    newOrder.OrderCost = ((Convert.ToDouble(numericUpDown2.Value) * SelectedProduct.ProductCost)*90)/100;
                else
                    newOrder.OrderCost = Convert.ToDouble(numericUpDown2.Value) * SelectedProduct.ProductCost;
                newOrder.CustomerStorage = comboBox2.GetItemText(comboBox2.SelectedItem);
                using (var db = new DbService())
                {
                    db.AddOrUpdateEntity<SupplyHistory>(newOrder);
                    RefreshTable();
                }
            }
            else
            {
                GerekliAlanlariDoldur gerekliAlanlariDoldur = new GerekliAlanlariDoldur();
                gerekliAlanlariDoldur.Show();
            }
        }
    }
}
