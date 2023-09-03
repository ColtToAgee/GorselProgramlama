using GorselProgramlama.Models;
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
    public partial class AdminHomeScreen : Form
    {
        public AdminHomeScreen()
        {
            InitializeComponent();
            label4.Text = StaticEntities.ActiveUsername;
        }

        private void admin_UserManagement_btn_Click(object sender, EventArgs e)
        {
            AdminUserManagementScreen adminUserManagementScreen = new AdminUserManagementScreen();
            adminUserManagementScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminProductManagementScreen adminProductManagementScreen = new AdminProductManagementScreen();
            adminProductManagementScreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStorageManagementScreen adminStorageManagementScreen = new AdminStorageManagementScreen();
            adminStorageManagementScreen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminSupplyManagementScreen adminSupplyManagementScreen = new AdminSupplyManagementScreen();
            adminSupplyManagementScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StaticEntities.ActiveUsername = "";
            StaticEntities.ActivePassword = "";
            StaticEntities.ActiveUserType = "";
            FirstScreen firstScreen = new FirstScreen();
            firstScreen.Show();
        }
    }
}
