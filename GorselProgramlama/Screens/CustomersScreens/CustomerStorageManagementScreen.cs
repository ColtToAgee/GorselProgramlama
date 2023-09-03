using System;
using System.Windows.Forms;

namespace GorselProgramlama.Screens.CustomersScreens
{
    public partial class CustomerStorageManagementScreen : Form
    {
        public CustomerStorageManagementScreen()
        {
            InitializeComponent();
            customerStorageManagementAddStorageScreen1.Hide();
            customerStorageManagementDeleteStorageScreen1.Hide();
            customerStorageManagementEditStorageScreen1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerStorageManagementAddStorageScreen1.Show();
            customerStorageManagementDeleteStorageScreen1.Hide();
            customerStorageManagementEditStorageScreen1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerStorageManagementAddStorageScreen1.Hide();
            customerStorageManagementDeleteStorageScreen1.Hide();
            customerStorageManagementEditStorageScreen1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerStorageManagementAddStorageScreen1.Hide();
            customerStorageManagementDeleteStorageScreen1.Show();
            customerStorageManagementEditStorageScreen1.Hide();
        }
    }
}
