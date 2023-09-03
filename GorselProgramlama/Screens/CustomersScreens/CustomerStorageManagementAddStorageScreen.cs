using GorselProgramlama.Models;
using GorselProgramlama.Screens.AdminScreens;
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
    public partial class CustomerStorageManagementAddStorageScreen : UserControl
    {
        public CustomerStorageManagementAddStorageScreen()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newStorage = new Storages();
            newStorage.StorageOwnerUsername = StaticEntities.ActiveUsername;
            newStorage.StorageLocation = textBox2.Text;
            newStorage.StorageName = textBox1.Text;
            newStorage.StorageOwnerType = "Müşteri";
            using (var db = new DbService())
            {
                var storageList = db.GetList<Storages>($"{nameof(Storages.StorageOwnerUsername)}='{StaticEntities.ActiveUsername}'");
                if (storageList.Where(a => a.StorageName == newStorage.StorageName).Count()==0)
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
