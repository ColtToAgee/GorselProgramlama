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
    public partial class AdminStorageManagementDeleteStorageScreen : UserControl
    {
        public string SelectedStorageId;
        public string SelectedType;
        public AdminStorageManagementDeleteStorageScreen()
        {
            InitializeComponent();
        }
        public void RefreshTable()
        {
            using(var db = new DbService())
            {
                var supplierStorageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerType)}='{SelectedType}'");
                dataGridView1.DataSource = supplierStorageList;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = comboBox1.GetItemText(comboBox1.SelectedItem);
            RefreshTable();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStorageId = selectedRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new DbService())
            {
                var storage = db.FirstOrDefault<Storages>($"{nameof(Products.Id)}={SelectedStorageId}");
                storage.RowStateId = 3;
                db.AddOrUpdateEntity<Storages>(storage);
                RefreshTable();
            }
        }
    }
}
