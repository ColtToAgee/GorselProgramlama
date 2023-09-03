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

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierSupplyManagementScreen : Form
    {
        public SupplyHistory SelectedSupplyHistory = new SupplyHistory();
        public SupplierSupplyManagementScreen()
        {
            InitializeComponent();
            using (var db = new DbService())
            {
                dataGridView1.DataSource = db.GetList<SupplyHistory>($"{nameof(SupplyHistory.Supplier)}='{StaticEntities.ActiveUsername}'");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            var selectedRow = dataGridView1.Rows[selectedRowIndex];
            SelectedSupplyHistory.Id = (int)selectedRow.Cells[7].Value;
            SelectedSupplyHistory.Product = selectedRow.Cells[0].Value.ToString();
            SelectedSupplyHistory.Supplier = selectedRow.Cells[1].Value.ToString();
            SelectedSupplyHistory.Customer= selectedRow.Cells[2].Value.ToString();
            SelectedSupplyHistory.ProductTotal = (int)selectedRow.Cells[3].Value;
            SelectedSupplyHistory.OrderCost = (double)selectedRow.Cells[4].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new DbService())
            {
                if (SelectedSupplyHistory.Id != 0)
                {
                    var stock = db.FirstOrDefault<StorageCapacity>($"{nameof(StorageCapacity.Product)}='{SelectedSupplyHistory.Product}' and {nameof(StorageCapacity.CreatedByUser)}='{SelectedSupplyHistory.Supplier}'");
                    if (stock != null && stock.NumberOfProduct >= SelectedSupplyHistory.ProductTotal)
                    {
                        stock.NumberOfProduct= stock.NumberOfProduct-SelectedSupplyHistory.ProductTotal;
                        var order = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedSupplyHistory.Id}");
                        order.IsCompleted = 1;
                        order.RowStateId = 3;
                        var customerStorageCapasity = db.FirstOrDefault<StorageCapacity>($"{nameof(StorageCapacity.Storage)}='{order.CustomerStorage}'");
                        if (customerStorageCapasity == null)
                        {
                            var newCustomerStorageCapasity = new StorageCapacity()
                            {
                                Product = order.Product,
                                Storage = order.CustomerStorage,
                                NumberOfProduct = SelectedSupplyHistory.ProductTotal,
                                CreatedByUser=order.Customer,
                                CreatedTime=DateTime.Now.ToString(),
                                RowStateId=1
                            };
                            db.AddOrUpdateEntity(newCustomerStorageCapasity);
                        }
                        else
                            customerStorageCapasity.NumberOfProduct= customerStorageCapasity.NumberOfProduct+SelectedSupplyHistory.ProductTotal;
                        db.AddOrUpdateEntity(order);
                        db.AddOrUpdateEntity(stock);
                        dataGridView1.DataSource = db.GetList<SupplyHistory>($"{nameof(SupplyHistory.Supplier)}='{StaticEntities.ActiveUsername}'");
                    }
                    else
                    {
                        StokYetersiz stokYetersiz = new StokYetersiz();
                        stokYetersiz.Show();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var db = new DbService())
            {
                if(SelectedSupplyHistory != null)
                {
                    var order = db.FirstOrDefault<SupplyHistory>($"{nameof(SupplyHistory.Id)}={SelectedSupplyHistory.Id}");
                    order.RowStateId = 3;
                    db.AddOrUpdateEntity(order);
                }
            }
        }
    }
}
