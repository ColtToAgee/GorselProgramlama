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

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierHomeScreen : Form
    {
        public SupplierHomeScreen()
        {
            InitializeComponent();
            label4.Text = StaticEntities.ActiveUsername;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierStorageManagementScreen screen = new SupplierStorageManagementScreen();
            screen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierSupplyManagementScreen screen = new SupplierSupplyManagementScreen();
            screen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplierProductManagementScreen screen = new SupplierProductManagementScreen();
            screen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupplierStockManagementScreen screen = new SupplierStockManagementScreen();
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
    }
}
