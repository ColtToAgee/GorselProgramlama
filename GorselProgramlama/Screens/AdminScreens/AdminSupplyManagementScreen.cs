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
    public partial class AdminSupplyManagementScreen : Form
    {
        private string SelectedSupplyHistoryId;
        public AdminSupplyManagementScreen()
        {
            InitializeComponent();
            var supplierList = ProductService.GetSupplierNames();
            foreach (var supplier in supplierList)
            {
                comboBox1.Items.Add(supplier);
            }
            var customerList = ProductService.GetCustomerNames();
            foreach (var customer in customerList)
            {
                comboBox2.Items.Add(customer);
            }
            dataGridView1.DataSource = SupplyService.GetSupplyHistoryList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedSupplyHistoryId = selectedRow.Cells[3].Value.ToString();
            var customerName = SupplyService.GetCustomerWithName(selectedRow.Cells[2].Value.ToString()).CustomerUserName;
            var supplierName = SupplyService.GetSupplierWithName(selectedRow.Cells[1].Value.ToString()).SupplierCompanyName;
            var productList = SupplyService.GetSupplierProductWithSupplierName(selectedRow.Cells[1].Value.ToString());
            var productName = SupplyService.GetProductWithId(selectedRow.Cells[0].Value.ToString()).ProductName;
            comboBox1.Text = supplierName;
            comboBox2.Text = customerName;
            comboBox3.Items.Clear();
            foreach (var product in productList)
            {
                comboBox3.Items.Add(product);
            }
            comboBox3.Text = productName;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSupplier = comboBox1.GetItemText(comboBox1.SelectedItem);
            var productList = SupplyService.GetSupplierProductWithSupplierName(selectedSupplier.ToString());
            comboBox3.Items.Clear();
            foreach (var product in productList)
            {
                comboBox3.Items.Add(product.ProductName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplier = SupplyService.GetSupplierWithName(comboBox1.GetItemText(comboBox1.SelectedItem));
            var customer = SupplyService.GetCustomerWithName(comboBox2.GetItemText(comboBox2.SelectedItem));
            var product = SupplyService.GetProductWithName(comboBox3.GetItemText(comboBox3.SelectedItem));
            var supplyHistory = new SupplyHistory();
            using (var db = new DbService())
            {
                supplyHistory = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedSupplyHistoryId}");
                supplyHistory.Supplier = supplier.SupplierCompanyName;
                supplyHistory.Customer = customer.CustomerUserName;
                supplyHistory.Product = product.ProductName;
                supplyHistory.RowStateId = 2;
                db.AddOrUpdateEntity(supplyHistory);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var supplyHistory = new SupplyHistory();
            using (var db = new DbService())
            {
                supplyHistory = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedSupplyHistoryId}");
                supplyHistory.RowStateId = 3;
                db.AddOrUpdateEntity(supplyHistory);
            }
        }
    }
}
