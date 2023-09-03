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
    public partial class AdminUserManagementScreen : Form
    {
        public AdminUserManagementScreen()
        {
            InitializeComponent();
            adminUserManagementAddUserScreen1.Hide();
            adminUserManagementDeleteUserScreen1.Hide();
            adminUserManagementEditUserScreen1.Hide();
        }

        private void add_User_btn_Click(object sender, EventArgs e)
        {
            adminUserManagementAddUserScreen1.Show();
            adminUserManagementDeleteUserScreen1.Hide();
            adminUserManagementEditUserScreen1.Hide();
        }

        private void edit_User_btn_Click(object sender, EventArgs e)
        {
            adminUserManagementAddUserScreen1.Hide();
            adminUserManagementDeleteUserScreen1.Hide();
            adminUserManagementEditUserScreen1.Show();
        }

        private void delete_User_btn_Click(object sender, EventArgs e)
        {
            adminUserManagementAddUserScreen1.Hide();
            adminUserManagementDeleteUserScreen1.Show();
            adminUserManagementEditUserScreen1.Hide();
        }
    }
}
