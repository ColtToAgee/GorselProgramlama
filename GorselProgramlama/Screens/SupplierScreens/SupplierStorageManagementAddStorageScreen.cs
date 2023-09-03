using GorselProgramlama.Models;
using GorselProgramlama.Screens.AdminScreens;
using GorselProgramlama.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierStorageManagementAddStorageScreen : UserControl
    {
        public SupplierStorageManagementAddStorageScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newStorage = new Storages();
            newStorage.StorageOwnerUsername = StaticEntities.ActiveUsername;
            newStorage.StorageLocation = textBox2.Text;
            newStorage.StorageName = textBox1.Text;
            newStorage.StorageOwnerType = "Tedarikçi";
            using (var db = new DbService())
            {
                var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                if (storageList.Where(a => a.StorageName == newStorage.StorageName).Count() == 0)
                    db.AddOrUpdateEntity(newStorage);
                else
                {
                    BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                    buIsimDahaOnceKullanilmis.Show();
                }
            }
        }
    }
}
