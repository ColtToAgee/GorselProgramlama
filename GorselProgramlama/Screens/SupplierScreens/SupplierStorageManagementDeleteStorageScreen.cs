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
    public partial class SupplierStorageManagementDeleteStorageScreen : UserControl
    {
        public string SelectedStorageId;

        public SupplierStorageManagementDeleteStorageScreen()
        {
            InitializeComponent();
            using(var db = new DbService())
            {
                dataGridView1.DataSource = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
            }
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
                if (SelectedStorageId != null)
                {
                    var storage = db.FirstOrDefault<Storages>($"{nameof(Storages.Id)}={SelectedStorageId}");
                    storage.RowStateId = 3;
                    db.AddOrUpdateEntity<Storages>(storage);
                    dataGridView1.DataSource = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                }
            }
        }
    }
}
