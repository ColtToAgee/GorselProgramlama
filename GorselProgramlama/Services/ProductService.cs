using GorselProgramlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public static class ProductService
    {
        public static List<string> GetCategoryNames()
        {
            var categoryList = new List<Categories>();
            using(var db = new DbService())
            {
                categoryList = db.GetList<Categories>();
            }
            var categoryNameList = categoryList.Select(a=>a.CategoryName).ToList();
            return categoryNameList;
        }

        public static List<Products> GetProducts()
        {
            var products = new List<Products>();
            using (var db = new DbService())
            {
                products= db.GetList<Products>();
            }
            return products;
        }

        public static List<Categories> GetCategories()
        {
            var categories = new List<Categories>();
            using(var db = new DbService()) 
            {
                categories = db.GetList<Categories>();
            }
            return categories;
        }
        public static List<string> GetSupplierNames()
        {
            var supplierList = new List<Suppliers>();
            using(var db = new DbService())
            {
                supplierList = db.GetList<Suppliers>();
            }
            var supplierNameList = supplierList.Select(a=>a.SupplierUserName).ToList();
            return supplierNameList;
        }

        public static List<string> GetCustomerNames()
        {
            var customerList = new List<Customers>();
            using(var db = new DbService())
            {
                customerList = db.GetList<Customers>();
            }
            var customerNameList = customerList.Select(a=>a.CustomerUserName).ToList();
            return customerNameList;
        }

        public static Categories GetCategoryWithName(string name)
        {
            var category = new Categories();
            using(var db = new DbService()) 
            { 
                category = db.FirstOrDefault<Categories>($"{nameof(Categories.CategoryName)}='{name}'");
            }
            return category;
        }

        public static List<Products> GetProductWithCategoryName(string name)
        {
            var products = new List<Products>();
            using (var db = new DbService())
            {
                products = db.GetList<Products>($"{nameof(Products.ProductCategory)}='{name}'");
            }
            return products;
        }

        public static List<SupplyHistory> GetOrdersWithCategoryNameForCustomer(string name,string customerName)
        {
            var orders = new List<SupplyHistory>();
            using(var db = new DbService())
            {
                var products = db.GetList<Products>($"{nameof(Products.ProductCategory)}='{name}'");
                foreach(var product in products)
                {
                    var orderList = db.GetList<SupplyHistory>($"{nameof(SupplyHistory.Product)}='{product.ProductName}' and {nameof(SupplyHistory.Customer)}='{customerName}'");
                    orders.AddRange(orderList); 
                }
            }
            return orders;
        }
    }
}
