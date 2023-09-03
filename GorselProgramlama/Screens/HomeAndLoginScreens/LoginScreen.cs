using GorselProgramlama.Models;
using GorselProgramlama.Screens.AdminScreens;
using GorselProgramlama.Screens.CustomersScreens;
using GorselProgramlama.Screens.SupplierScreens;
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

namespace GorselProgramlama
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string password = txt_Password.Text;
            using (var db=new DbService())
            {
                switch (this.loginType)
                {
                    case "Admin":
                        var adminTempUser = db.FirstOrDefault<Admins>($"{nameof(Admins.AdminUserName)}='{userName}' and {nameof(Admins.AdminPassword)}='{password}'");
                        if(adminTempUser != null)
                        {
                            StaticEntities.ActiveUserType = "Admin";
                            StaticEntities.ActiveUsername = userName;
                            StaticEntities.ActivePassword = password;
                            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
                            adminHomeScreen.Show();
                            this.Hide();
                        }
                        else
                        {
                            FailedLoginModal failedLoginModal = new FailedLoginModal();
                            failedLoginModal.Show();
                        }
                        break;
                    case "Customer":
                        var customerTempUser = db.FirstOrDefault<Customers>($"{nameof(Customers.CustomerUserName)}='{userName}' and {nameof(Customers.CustomerPassword)}='{password}'");
                        if(customerTempUser != null)
                        {
                            StaticEntities.ActiveUserType = "Customer";
                            StaticEntities.ActiveUsername = userName;
                            StaticEntities.ActivePassword = password;
                            CustomerHomeScreen customerHomeScreen = new CustomerHomeScreen();
                            customerHomeScreen.Show();
                            this.Hide();
                        }
                        else
                        {
                            FailedLoginModal failedLoginModal = new FailedLoginModal();
                            failedLoginModal.Show();
                        }
                        break;
                    case "Supplier":
                        var supplierTempUser = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierUserName)}='{userName}' and {nameof(Suppliers.SupplierPassword)}='{password}'");
                        if(supplierTempUser != null)
                        {
                            StaticEntities.ActiveUserType = "Supplier";
                            StaticEntities.ActiveUsername = userName;
                            StaticEntities.ActivePassword = password;
                            SupplierHomeScreen supplierHomeScreen = new SupplierHomeScreen();
                            supplierHomeScreen.Show();
                            this.Hide();
                        }
                        else
                        {
                            FailedLoginModal failedLoginModal = new FailedLoginModal();
                            failedLoginModal.Show();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
