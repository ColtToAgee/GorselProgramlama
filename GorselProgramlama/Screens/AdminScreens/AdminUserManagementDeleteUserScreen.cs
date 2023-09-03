using GorselProgramlama.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GorselProgramlama.Screens.AdminScreens
{
    public partial class AdminUserManagementDeleteUserScreen : UserControl
    {
        public AdminUserManagementDeleteUserScreen()
        {
            InitializeComponent();
        }
        public string SelectedUserUserName { get; set; }
        public string SelectedUserPassword { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedType = comboBox1.GetItemText(comboBox1.SelectedItem);
            using (var db = new DbService())
            {
                switch (selectedType)
                {
                    case "Tedarikçi":
                        var supplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierUserName)}='{SelectedUserUserName}' and {nameof(Suppliers.SupplierPassword)}='{SelectedUserPassword}'");
                        supplier.RowStateId = 3;
                        db.AddOrUpdateEntity<Suppliers>(supplier);
                        var supplierList = db.GetList<Suppliers>();
                        dataGridView1.DataSource = supplierList;
                        break;
                    case "Admin":
                        var admin = db.FirstOrDefault<Admins>($"{nameof(Admins.AdminUserName)}='{SelectedUserUserName}' and {nameof(Admins.AdminPassword)}='{SelectedUserPassword}'");
                        admin.RowStateId = 3;
                        db.AddOrUpdateEntity<Admins>(admin);
                        var adminList = db.GetList<Admins>();
                        dataGridView1.DataSource = adminList;
                        break;
                    case "Müşteri":
                        var customer = db.FirstOrDefault<Customers>($"{nameof(Customers.CustomerUserName)}='{SelectedUserUserName}' and {nameof(Customers.CustomerPassword)}='{SelectedUserPassword}'");
                        customer.RowStateId = 3;
                        db.AddOrUpdateEntity<Customers>(customer);
                        var customerList = db.GetList<Customers>();
                        dataGridView1.DataSource = customerList;
                        break;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            var selectedType = comboBox1.GetItemText(comboBox1.SelectedItem);
            SelectedUserUserName = selectedRow.Cells[0].Value.ToString();
            SelectedUserPassword = selectedRow.Cells[1].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = comboBox1.GetItemText(comboBox1.SelectedItem);
            using (var db = new DbService())
            {
                switch (selectedType)
                {
                    case "Müşteri":
                        var customerList = db.GetList<Customers>();
                        dataGridView1.DataSource = customerList;
                        break;
                    case "Admin":
                        var adminList = db.GetList<Admins>();
                        dataGridView1.DataSource = adminList;
                        break;
                    case "Tedarikçi":
                        var supplierList = db.GetList<Suppliers>();
                        dataGridView1.DataSource = supplierList;
                        break;
                }
            }
        }
    }
}
