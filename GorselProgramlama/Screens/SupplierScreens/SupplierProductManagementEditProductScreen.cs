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

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierProductManagementEditProductScreen : UserControl
    {
        public string SelectedProductId;
        public string SelectedCategory;
        public SupplierProductManagementEditProductScreen()
        {
            InitializeComponent();
            //Kategori isimlerinin yüklendiği kısım
            foreach (var item in ProductService.GetCategoryNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen kategoriye göre o kategorinin ürünlerinin listelendiği kısım
            SelectedCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (SelectedCategory != null)
            {
                using (var db = new DbService())
                {
                    var productList = db.GetList<Products>($"{nameof(Products.ProductCategory)}='{SelectedCategory}'");
                    dataGridView1.DataSource = productList;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tablodan kayıt seçildiği zaman boşlukların doldurulduğu kısım
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedProductId = selectedRow.Cells[4].Value.ToString();
            var product = new Products();
            using (var db = new DbService())
            {
                product = db.FirstOrDefault<Products>($"{nameof(Products.Id)}={SelectedProductId}");
            }
            textBox3.Text = product.ProductName;
            textBox2.Text = product.ProductCost.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kaydete basıldığında çalışan kısım
            if (textBox3.Text != "" && textBox2.Text != "")
            {
                var product = new Products()
                {
                    Id = Convert.ToInt32(SelectedProductId),
                    ProductName = textBox3.Text,
                    ProductCost = Convert.ToDouble(textBox2.Text),
                    ProductSupplier = StaticEntities.ActiveUsername,
                    ProductCategory = SelectedCategory,
                    CreatedByUser = StaticEntities.ActiveUsername,
                    CreatedTime = DateTime.Now.ToString(),
                    RowStateId = 2
                };
                using (var db = new DbService())
                {
                    db.AddOrUpdateEntity<Products>(product);
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
