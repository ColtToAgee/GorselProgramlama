using GorselProgramlama.Models;
using GorselProgramlama.Screens.HomeAndLoginScreens;
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
    public partial class AdminProductManagementAddProductScreen : UserControl
    {
        public AdminProductManagementAddProductScreen()
        {
            InitializeComponent();
            foreach (var item in ProductService.GetCategoryNames())
            {
                comboBox1.Items.Add(item);
            }
            foreach(var item in ProductService.GetSupplierNames())
            {
                comboBox2.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productName = textBox1.Text;
            var productSupplier = comboBox2.GetItemText(comboBox2.SelectedItem);
            var productCost = textBox3.Text;
            var productCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(productName != "" && productSupplier != "" && productCost != "" && productCategory != "")
            {
                using(var db = new DbService())
                {
                    var newProduct = new Products()
                    {
                        ProductName = productName,
                        ProductSupplier = productSupplier,
                        ProductCost = Convert.ToDouble(productCost),
                        ProductCategory = productCategory,
                        CreatedByUser = StaticEntities.ActiveUsername,
                        CreatedTime = DateTime.Now.ToString()
                    };
                    db.AddOrUpdateEntity(newProduct);
                    textBox1.Text = "";
                    comboBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                }
            }
            else
            {
                GerekliAlanlariDoldur gerekliAlanlariDoldur = new GerekliAlanlariDoldur();
                gerekliAlanlariDoldur.Show();
            }
        }
    }
}
