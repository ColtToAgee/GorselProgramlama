using GorselProgramlama.Models;
using GorselProgramlama.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GorselProgramlama.Screens.AdminScreens
{
    public partial class AdminUserManagementAddUserScreen : UserControl
    {
        public AdminUserManagementAddUserScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedListIndex = comboBox1.GetItemText(comboBox1.SelectedItem);
            var userName = textBox1.Text;
            var password = textBox2.Text;
            using (var db = new DbService())
            {
                switch (selectedListIndex)
                {
                    case "Admin":
                        var newAdmin = new Admins()
                        {
                            AdminUserName = userName,
                            AdminPassword = password,
                            CreatedByUser = StaticEntities.ActiveUsername,
                            CreatedTime = DateTime.Now.ToString(),
                            RowStateId = 1
                        };
                        var adminList = db.GetList<Admins>();
                        if (adminList.Where(a => a.AdminUserName == userName).Count()==0)
                            db.AddOrUpdateEntity(newAdmin);
                        else
                        {
                            BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                            buIsimDahaOnceKullanilmis.Show();
                        }
                        break;
                    case "Müşteri":
                        var newCustomer = new Customers()
                        {
                            CustomerUserName = userName,
                            CustomerPassword = password,
                            CreatedByUser = StaticEntities.ActiveUsername,
                            CreatedTime = DateTime.Now.ToString(),
                            RowStateId = 1
                        };
                        var customerList = db.GetList<Customers>();
                        if (customerList.Where(a => a.CustomerUserName == userName).Count() == 0)
                            db.AddOrUpdateEntity(newCustomer);
                        else
                        {
                            BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                            buIsimDahaOnceKullanilmis.Show();
                        }
                        break;
                    case "Tedarikçi":
                        var newSupplier = new Suppliers()
                        {
                            SupplierUserName = userName,
                            SupplierPassword = password,
                            CreatedByUser = StaticEntities.ActiveUsername,
                            CreatedTime = DateTime.Now.ToString(),
                            RowStateId = 1
                        };
                        var supplierList = db.GetList<Suppliers>();
                        if (supplierList.Where(a => a.SupplierUserName == userName).Count() == 0)
                            db.AddOrUpdateEntity(newSupplier);
                        else
                        {
                            BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                            buIsimDahaOnceKullanilmis.Show();
                        }
                        break;
                }
            }
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }


    }
}
