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

namespace GorselProgramlama.Screens.CustomersScreens
{
    public partial class CustomerHomeScreen : Form
    {
        public CustomerHomeScreen()
        {
            InitializeComponent();
            label4.Text = StaticEntities.ActiveUsername;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerStorageManagementScreen screen = new CustomerStorageManagementScreen();
            screen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerOrderManagementScreen screen = new CustomerOrderManagementScreen();
            screen.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerStockManagementScreen screen = new CustomerStockManagementScreen();
            screen.Show();
        }
    }
}
