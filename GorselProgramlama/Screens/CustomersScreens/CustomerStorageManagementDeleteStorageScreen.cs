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

namespace GorselProgramlama.Screens.CustomersScreens
{
    public partial class CustomerStorageManagementDeleteStorageScreen : UserControl
    {
        public string SelectedStorageId;
        public CustomerStorageManagementDeleteStorageScreen()
        {
            InitializeComponent();
            //Müşterinin depolarının listelendiği kısım
            using (var db = new DbService())
            {
                dataGridView1.DataSource = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Silme işleminin yapıldığı kısım
            using (var db = new DbService())
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

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Tablo üzerinden kayıt seçilip hangi kayıdın silinceği belli ediliyor.
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedStorageId = selectedRow.Cells[4].Value.ToString();
        }
    }
}
