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
    public partial class CustomerStockManagementScreen : Form
    {
        public string SelectedStorage;
        public StorageCapacity SelectedStock = new StorageCapacity();

        public CustomerStockManagementScreen()
        {
            InitializeComponent();
            using(var db = new DbService())
            {
                //Kullanıcının depolarının depo seçiniz alanına eklendiği kısım
                var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                foreach (var storage in storageList)
                {
                    comboBox2.Items.Add(storage.StorageName);
                }
            }

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Kullanıcı seçtiği anda tablonun doldurulduğu kısım
            SelectedStorage = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (SelectedStorage != "")
            {
                using (var db = new DbService())
                {
                    var stockList = db.GetList<StorageCapacity>($"{nameof(StorageCapacity.Storage)}='{SelectedStorage}'");
                    dataGridView1.DataSource = stockList;
                    foreach (var item in stockList)
                    {
                        if (item.NumberOfProduct < 10)
                        {
                            StokAzaldi stokAzaldi = new StokAzaldi();
                            stokAzaldi.AzalanUrun = item.Product;
                        }
                        comboBox1.Items.Add(item.Product);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Kullanıcı tablodan bir kayıt seçtiğinde değişkene attığı kısım
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStock.Storage = selectedRow.Cells[0].Value.ToString();
            SelectedStock.Product = selectedRow.Cells[1].Value.ToString();
            SelectedStock.NumberOfProduct = (int)selectedRow.Cells[2].Value;
            SelectedStock.Id = (int)selectedRow.Cells[3].Value;
            comboBox1.Text = SelectedStock.Product;
            numericUpDown1.Value = SelectedStock.NumberOfProduct;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Düzenleye basınca çalışacak kısım
            if (comboBox1.Text != "" && numericUpDown1 != null)
            {
                if (SelectedStock == null)
                {
                    var newStock = new StorageCapacity()
                    {
                        Product = comboBox1.GetItemText(comboBox1.SelectedItem),
                        Storage = SelectedStorage,
                        NumberOfProduct = (int)numericUpDown1.Value,
                    };
                }
                else
                {
                    using (var db = new DbService())
                    {
                        var stock = db.FirstOrDefault<StorageCapacity>($"{nameof(StorageCapacity.Id)}={SelectedStock.Id}");
                        stock.Product = comboBox1.GetItemText(comboBox1.SelectedItem);
                        stock.NumberOfProduct = (int)numericUpDown1.Value;
                        db.AddOrUpdateEntity(stock);
                        var stockList = db.GetList<StorageCapacity>($"{nameof(StorageCapacity.Storage)}='{SelectedStorage}'");
                        dataGridView1.DataSource = stockList;
                    }
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
