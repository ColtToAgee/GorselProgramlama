using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierProductManagementScreen : Form
    {
        public SupplierProductManagementScreen()
        {
            InitializeComponent();
            supplierProductManagementAddProductScreen1.Hide();
            supplierProductManagementDeleteProductScreen1.Hide();
            supplierProductManagementEditProductScreen1.Hide();
        }

        private void add_User_btn_Click(object sender, EventArgs e)
        {
            supplierProductManagementAddProductScreen1.Show();
            supplierProductManagementDeleteProductScreen1.Hide();
            supplierProductManagementEditProductScreen1.Hide();
        }

        private void edit_User_btn_Click(object sender, EventArgs e)
        {
            supplierProductManagementAddProductScreen1.Hide();
            supplierProductManagementDeleteProductScreen1.Hide();
            supplierProductManagementEditProductScreen1.Show();
        }

        private void delete_User_btn_Click(object sender, EventArgs e)
        {
            supplierProductManagementAddProductScreen1.Hide();
            supplierProductManagementDeleteProductScreen1.Show();
            supplierProductManagementEditProductScreen1.Hide();
        }
    }
}
