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

namespace GorselProgramlama.Screens.AdminScreens
{
    public partial class AdminUserManagementEditUserScreen : UserControl
    {
        public AdminUserManagementEditUserScreen()
        {
            InitializeComponent();
        }

        public string SelectedUserUserName { get; set; }
        public string SelectedUserPassword { get; set; }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = comboBox2.GetItemText(comboBox2.SelectedItem);
            using (var db = new DbService())
            {
                switch (selectedType)
                {
                    case "Tedarikçi":
                        var supplierList = db.GetList<Suppliers>();
                        dataGridView1.DataSource = supplierList;
                        break;
                    case "Admin":
                        var adminList = db.GetList<Admins>();
                        dataGridView1.DataSource = adminList;
                        break;
                    case "Müşteri":
                        var customerList = db.GetList<Customers>();
                        dataGridView1.DataSource = customerList;
                        break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userType = comboBox2.GetItemText(comboBox2.SelectedItem);
            var userName = textBox1.Text;
            var password = textBox2.Text;
            using (var db = new DbService())
            {
                switch (userType)
                {
                    case "Tedarikçi":
                        var supplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierUserName)}='{SelectedUserUserName}' and {nameof(Suppliers.SupplierPassword)}='{SelectedUserPassword}'");
                        var newSupplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierUserName)}='{userName}' and {nameof(Suppliers.SupplierPassword)}='{password}'");
                        if (newSupplier == null)
                        {
                            supplier.SupplierUserName = userName;
                            supplier.SupplierPassword = password;
                            db.AddOrUpdateEntity<Suppliers>(supplier);
                            var supplierList = db.GetList<Suppliers>();
                            dataGridView1.DataSource = supplierList;
                        }
                        break;
                    case "Admin":
                        var admin = db.FirstOrDefault<Admins>($"{nameof(Admins.AdminUserName)}='{SelectedUserUserName}' and {nameof(Admins.AdminPassword)}='{SelectedUserPassword}'");
                        var newAdmin = db.FirstOrDefault<Admins>($"{nameof(Admins.AdminUserName)}='{userName}' and {nameof(Admins.AdminPassword)}='{password}'");
                        if (newAdmin == null)
                        {
                            admin.AdminUserName = userName;
                            admin.AdminPassword = password;
                            db.AddOrUpdateEntity<Admins>(admin);
                            var adminList = db.GetList<Admins>();
                            dataGridView1.DataSource = adminList;
                        }
                        break;
                    case "Müşteri":
                        var customer = db.FirstOrDefault<Customers>($"{nameof(Customers.CustomerUserName)}='{SelectedUserUserName}' and {nameof(Customers.CustomerPassword)}='{SelectedUserPassword}'");
                        var newCustomer = db.FirstOrDefault<Customers>($"{nameof(Customers.CustomerUserName)}='{userName}' and {nameof(Customers.CustomerPassword)}='{password}'");
                        if (newCustomer == null)
                        {
                            customer.CustomerUserName = userName;
                            customer.CustomerPassword = password;
                            db.AddOrUpdateEntity<Customers>(customer);
                            var customerList = db.GetList<Customers>();
                            dataGridView1.DataSource = customerList;
                        }
                        break;
                }
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            var selectedType = comboBox2.GetItemText(comboBox2.SelectedItem);
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            SelectedUserUserName = selectedRow.Cells[0].Value.ToString();
            SelectedUserPassword = selectedRow.Cells[1].Value.ToString();
        }

    }
}
