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
    public partial class FirstScreen : Form
    {
        public FirstScreen()
        {
            InitializeComponent();
        }


        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.loginType = "Admin";
            loginScreen.Show();
            this.Hide();
        }

        private void btn_CustomerLogin_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.loginType = "Customer";
            loginScreen.Show();
            this.Hide();
        }

        private void btn_SupplierLogin_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.loginType = "Supplier";
            loginScreen.Show();
            this.Hide();
        }
    }
}
