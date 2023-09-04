using GorselProgramlama.Models;
using GorselProgramlama.Screens.HomeAndLoginScreens;
using GorselProgramlama.Services;
using System;
using System.Collections;
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
    public partial class SupplierStockManagementScreen : Form
    {
        public string SelectedStorage;
        public StorageCapacity SelectedStock = new StorageCapacity();
        private List<StorageCapacity> stockList = new List<StorageCapacity>();
        public SupplierStockManagementScreen()
        {
            InitializeComponent();
            //Kullanıcının depolarının depo seçiniz alanına yüklendiği kısım
            using (var db = new DbService())
            {
                var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                foreach (var storage in storageList)
                {
                    comboBox2.Items.Add(storage.StorageName);
                }
            }
            //Kategori seçiniz kısmına kategori isimlerinin yüklendiği kısım
            var categoryList = ProductService.GetCategories();
            foreach (var category in categoryList)
            {
                comboBox3.Items.Add(category.CategoryName);
            }
        }
        private void RefreshTable()
        {
            //tabloya veri yükleme kısmı
            using (var db = new DbService())
            {
                stockList = db.GetList<StorageCapacity>($"{nameof(StorageCapacity.Storage)}='{SelectedStorage}'");
                dataGridView1.DataSource = stockList;
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tablodan kayıt seçildiği anda boşlukların yüklendiği kısım ve değişkene atıldığı kısım
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStock.Storage = selectedRow.Cells[0].Value.ToString();
            SelectedStock.Product = selectedRow.Cells[1].Value.ToString();
            SelectedStock.NumberOfProduct = (int)selectedRow.Cells[2].Value;
            SelectedStock.Id = (int)selectedRow.Cells[3].Value;
            comboBox1.Text = SelectedStock.Product;
            numericUpDown1.Value = SelectedStock.NumberOfProduct;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Depo seçildikten sonra depodaki ürünlerin yüklendiği kısım
            SelectedStorage = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (SelectedStorage != "")
            {
                RefreshTable();
                foreach (var item in stockList)
                {
                    //Depodaki ürünün sayısı 10 ve altına düştüğünde uyarı çıkarılan kısım
                    if (item.NumberOfProduct <= 10)
                    {
                        StokAzaldi stokAzaldi = new StokAzaldi();
                        stokAzaldi.AzalanUrun = item.Product;
                        stokAzaldi.Show();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Düzenleme butonu çalıştığı kısım
            if (comboBox1.Text != "" && numericUpDown1 != null)
            {
                if (SelectedStock.Id == 0)//Stokta o üründen yoksa yeni stok oluşuyo
                {
                    var newStock = new StorageCapacity()
                    {
                        Product = comboBox1.GetItemText(comboBox1.SelectedItem),
                        Storage = SelectedStorage,
                        NumberOfProduct = (int)numericUpDown1.Value,
                    };
                    using(var db = new DbService())
                    {
                        db.AddOrUpdateEntity(newStock);
                        RefreshTable();
                    }
                }
                else//varsada adet alanındaki sayı yazılıyor
                {
                    using (var db = new DbService())
                    {
                        var stock = db.FirstOrDefault<StorageCapacity>($"{nameof(StorageCapacity.Id)}={SelectedStock.Id}");
                        stock.Product = comboBox1.GetItemText(comboBox1.SelectedItem)==""?comboBox1.Text: comboBox1.GetItemText(comboBox1.SelectedItem);
                        stock.NumberOfProduct = (int)numericUpDown1.Value;
                        stock.RowStateId = 2;
                        db.AddOrUpdateEntity(stock);
                        RefreshTable();
                    }
                }
            }
            else
            {
                GerekliAlanlariDoldur gerekliAlanlariDoldur = new GerekliAlanlariDoldur();
                gerekliAlanlariDoldur.Show();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kategori seçildiği anda ürünlerin getirildiği kısım
            var categoyName = comboBox3.GetItemText(comboBox3.SelectedItem);
            var productList = ProductService.GetProductWithCategoryName(categoyName);
            comboBox1.Items.Clear();
            foreach (var product in productList)
            {
                comboBox1.Items.Add(product.ProductName);
            }
        }
    }
}
