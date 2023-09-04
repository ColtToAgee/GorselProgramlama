using GorselProgramlama.Models;
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

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierProductManagementDeleteProductScreen : UserControl
    {
        public string SelectedProductId;
        public string SelectedCategory;
        public SupplierProductManagementDeleteProductScreen()
        {
            InitializeComponent();
            //Kategori seçiniz alanına isimlerinin yüklendiği kısım
            foreach (var item in ProductService.GetCategoryNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        public void RefreshTable()
        {
            //Tabloya veri yükleme kısmı
            using (var db = new DbService())
            {
                var productList = db.GetList<Products>($"{nameof(Products.ProductCategory)}='{SelectedCategory}' and {nameof(Products.ProductSupplier)}='{StaticEntities.ActiveUsername}'");
                dataGridView1.DataSource = productList;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //kayıt seçildiği anda seçilen kayıtın id sini aldığımız kısım
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedProductId = selectedRow.Cells[4].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kategori seçildiği anda o kategorinin ürünlerinin listelendiği kısım
            SelectedCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (SelectedCategory != null)
            {
                RefreshTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Silme kısmı
            if (SelectedProductId != null)
            {
                using (var db = new DbService())
                {
                    var product = db.FirstOrDefault<Products>($"{nameof(Products.Id)}={SelectedProductId}");
                    product.RowStateId = 3;
                    db.AddOrUpdateEntity<Products>(product);
                    RefreshTable();
                }
            }
        }
    }
}
