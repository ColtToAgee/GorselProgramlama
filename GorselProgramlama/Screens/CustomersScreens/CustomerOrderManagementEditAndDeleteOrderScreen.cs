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

namespace GorselProgramlama.Screens.CustomersScreens
{
    public partial class CustomerOrderManagementEditAndDeleteOrderScreen : UserControl
    {
        private SupplyHistory SelectedOrder = new SupplyHistory();
        private string SelectedCategory;
        public CustomerOrderManagementEditAndDeleteOrderScreen()
        {
            InitializeComponent();
            //Ürün kategorisi seçiniz alanına kategori isimlerinin yüklendiği yer
            var categories=ProductService.GetCategories();
            foreach (var item in categories)
            {
                comboBox5.Items.Add(item.CategoryName);
            }
        }
        public void RefreshTable()
        {
            //tabloya verilerin geldiği yer
            var orders = ProductService.GetOrdersWithCategoryNameForCustomer(SelectedCategory, StaticEntities.ActiveUsername);
            dataGridView5.DataSource = orders;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kategori seçildiği anda tabloya o kategorinin ürünlerinin getirildiği yer
            SelectedCategory = comboBox5.GetItemText(comboBox5.SelectedItem);
            RefreshTable();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tabloda kayıt seçildiğinde değişkene atıldığı ve alanların doldurulduğu kısım
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView5.Rows[selectedRowIndex];
            SelectedOrder.Id = (int)selectedRow.Cells[7].Value;
            SelectedOrder.Supplier = selectedRow.Cells[1].Value.ToString();
            SelectedOrder.Product = selectedRow.Cells[0].Value.ToString();
            SelectedOrder.Customer = selectedRow.Cells[2].ToString();
            SelectedOrder.ProductTotal = (int)selectedRow.Cells[3].Value;
            SelectedOrder.OrderCost = (double)selectedRow.Cells[4].Value;
            numericUpDown1.Value = SelectedOrder.ProductTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sipariş düzenle butonunun çalıştığı kısım
            if(numericUpDown1.Value != 0 && SelectedOrder != null)
            {
                using(var db = new DbService())
                {
                    var order = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedOrder.Id}");
                    order.ProductTotal = (int)numericUpDown1.Value;
                    order.OrderCost=(SelectedOrder.OrderCost/SelectedOrder.ProductTotal)*(int)numericUpDown1.Value;
                    db.AddOrUpdateEntity<SupplyHistory>(order);
                    RefreshTable();
                }
            }
            else
            {
                GerekliAlanlariDoldur gerekliAlanlariDoldur = new GerekliAlanlariDoldur();
                gerekliAlanlariDoldur.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sipariş iptal etme butonunun çalıştığı kısım
            using(var db = new DbService())
            {
                var order = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedOrder.Id}");
                order.RowStateId = 3;
                db.AddOrUpdateEntity(order);
                RefreshTable();
            }
        }
    }
}
