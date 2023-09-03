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
    public partial class AdminStorageManagementAddStorageScreen : UserControl
    {
        public string SelectedOwnerType;
        public AdminStorageManagementAddStorageScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newStorage = new Storages()
            {
                StorageName = textBox1.Text,
                StorageOwnerType = SelectedOwnerType,
                StorageOwnerUsername = comboBox1.GetItemText(comboBox1.SelectedItem),
                StorageLocation = textBox2.Text,
                CreatedByUser = StaticEntities.ActiveUsername,
                CreatedTime = DateTime.Now.ToString(),
                RowStateId = 1
            };
            using(var db = new DbService())
            {
                var storageList = db.GetList<Storages>();
                if(storageList.Where(a=>a.StorageName==newStorage.StorageName).Count()==0)
                    db.AddOrUpdateEntity<Storages>(newStorage);
                else
                {
                    BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                    buIsimDahaOnceKullanilmis.Show();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOwnerType = comboBox2.GetItemText(comboBox2.SelectedItem);
            var ownerList = StorageService.GetOwnerList(SelectedOwnerType);
            foreach( var owner in ownerList )
            {
                comboBox1.Items.Add( owner );
            }         
        }
    }
}
