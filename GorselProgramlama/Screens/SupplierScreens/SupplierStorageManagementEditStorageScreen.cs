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

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierStorageManagementEditStorageScreen : UserControl
    {
        public Storages SelectedStorage = new Storages();
        public SupplierStorageManagementEditStorageScreen()
        {
            InitializeComponent();
            using(var db = new DbService())
            {
                var storages = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                dataGridView1.DataSource = storages;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStorage.Id = (int)selectedRow.Cells[4].Value;
            SelectedStorage.StorageName = selectedRow.Cells[0].Value.ToString();
            SelectedStorage.StorageOwnerType = "Tedarikçi";
            SelectedStorage.StorageOwnerUsername = StaticEntities.ActiveUsername;
            SelectedStorage.StorageLocation = selectedRow.Cells[3].Value.ToString();
            textBox2.Text = SelectedStorage.StorageLocation;
            textBox3.Text = SelectedStorage.StorageName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new DbService()) 
            {
                var storage = db.FirstOrDefault<Storages>($"{nameof(Storages.Id)}={SelectedStorage.Id}");
                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    storage.StorageLocation = textBox2.Text;
                    storage.StorageName = textBox3.Text;
                    db.AddOrUpdateEntity(storage);
                }
                else
                {
                    GerekliAlanlariDoldur gerekliAlanlariDoldur = new GerekliAlanlariDoldur();
                    gerekliAlanlariDoldur.Show();
                }
            }
        }
    }
}
