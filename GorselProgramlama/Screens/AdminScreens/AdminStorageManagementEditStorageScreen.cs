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

namespace GorselProgramlama.Screens.AdminScreens
{
    public partial class AdminStorageManagementEditStorageScreen : UserControl
    {
        public AdminStorageManagementEditStorageScreen()
        {
            InitializeComponent();
        }
        public string SelectedStorageId;
        public string SelectedCategory;
        public void RefreshTable(DbService db)
        {
            var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerType)}='{SelectedCategory}'");
            dataGridView1.DataSource = storageList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            using (var db = new DbService())
            {
                switch (SelectedCategory)
                {
                    case "Tedarikçi":
                        comboBox2.Items.Clear();
                        var supplierList = db.GetList<Suppliers>();
                        RefreshTable(db);
                        foreach (var supplier in supplierList)
                        {
                            comboBox2.Items.Add(supplier.SupplierUserName);
                        }
                        break;
                    case "Müşteri":
                        comboBox2.Items.Clear();
                        var customerList = db.GetList<Customers>();
                        RefreshTable(db);
                        foreach (var customer in customerList)
                        {
                            comboBox2.Items.Add(customer.CustomerUserName);
                        }
                        break;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStorageId = selectedRow.Cells[4].Value.ToString();
            var storage = new Storages();
            using(var db = new DbService())
            {
                storage = db.FirstOrDefault<Storages>($"{nameof(Storages.Id)}={SelectedStorageId}");
            }
            textBox3.Text = storage.StorageName;
            comboBox2.Text = storage.StorageOwnerUsername;
            textBox2.Text = storage.StorageLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var storage = new Storages();
            using (var db = new DbService())
            {
                storage = db.FirstOrDefault<Storages>($"{nameof(Storages.Id)}={SelectedStorageId}");
                storage.StorageName = textBox3.Text;
                storage.StorageOwnerUsername = comboBox2.Text;
                storage.StorageLocation = textBox2.Text;
                db.AddOrUpdateEntity<Storages>(storage);
                RefreshTable(db);
            }
        }
    }
}
