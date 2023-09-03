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
    public partial class AdminProductManagementScreen : Form
    {
        public AdminProductManagementScreen()
        {
            InitializeComponent();
            adminProductManagementAddProductScreen1.Hide();
            adminProductManagementDeleteProductScreen1.Hide();
            adminProductManagementEditProductScreen1.Hide();
        }

        private void add_User_btn_Click(object sender, EventArgs e)
        {
            adminProductManagementAddProductScreen1.Show();
            adminProductManagementDeleteProductScreen1.Hide();
            adminProductManagementEditProductScreen1.Hide();
        }

        private void edit_User_btn_Click(object sender, EventArgs e)
        {
            adminProductManagementAddProductScreen1.Hide();
            adminProductManagementDeleteProductScreen1.Hide();
            adminProductManagementEditProductScreen1.Show();
        }

        private void delete_User_btn_Click(object sender, EventArgs e)
        {
            adminProductManagementAddProductScreen1.Hide();
            adminProductManagementDeleteProductScreen1.Show();
            adminProductManagementEditProductScreen1.Hide();
        }
    }
}
