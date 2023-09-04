using GorselProgramlama.Models;
using GorselProgramlama.Screens.AdminScreens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlama.Screens.SupplierScreens
{
    public partial class SupplierProductManagementAddProductScreen : UserControl
    {
        public SupplierProductManagementAddProductScreen()
        {
            InitializeComponent();
            //Kategori alanına kategori isimlerinin yüklendiği kısım
            foreach (var item in ProductService.GetCategoryNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ürün ekleme butonunun çalıştığı kısım
            var productName = textBox1.Text;
            var productSupplier = StaticEntities.ActiveUsername;
            var productCost = textBox3.Text;
            var productCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (productName != "" && productSupplier != "" && productCost != "" && productCategory != "")
            {
                using (var db = new DbService())
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
                    var productList = db.GetList<Products>($"{nameof(Products.ProductSupplier)}='{StaticEntities.ActiveUsername}'");
                    if(productList.Where(a => a.ProductName == productName).Count() == 0)//Eğer üründen daha önce yoksa eklendiği kısım
                        db.AddOrUpdateEntity(newProduct);
                    else
                    {
                        BuIsimDahaOnceKullanilmis buIsimDahaOnceKullanilmis = new BuIsimDahaOnceKullanilmis();
                        buIsimDahaOnceKullanilmis.Show();
                    }
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
