using GorselProgramlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public class SupplyService
    {
        public static List<SupplyHistory> GetSupplyHistoryList()
        {
            var supplyHistoryList = new List<SupplyHistory>();
            using(var db = new DbService())
            {
                supplyHistoryList = db.GetList<SupplyHistory>();
            }
            return supplyHistoryList;
        }

        public static List<Products> GetSupplierProductWithId(string id)
        {
            var productList = new List<Products>();
            using(var db = new DbService())
            {
                productList = db.GetList<Products>($"{nameof(Products.ProductSupplier)}={id}");
            }
            return productList;
        }

        public static List<Products> GetSupplierProductWithSupplierName(string supplierName)
        {
            var productList = new List<Products>();
            var supplier = new Suppliers();
            using (var db = new DbService())
            {
                supplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierUserName)}='{supplierName}'");
                productList = db.GetList<Products>($"{nameof(Products.ProductSupplier)}='{supplier.SupplierUserName}'");
            }
            return productList;
        }

        public static Customers GetCustomerWithId(string id)
        {
            var customer = new Customers();
            using (var db = new DbService())
            {
                customer = db.FirstOrDefault<Customers>($"{nameof(Customers.Id)}={id}");
            }
            return customer;
        }

        public static Products GetProductWithId(string id)
        {
            var product = new Products();
            using (var db = new DbService())
            {
                product = db.FirstOrDefault<Products>($"{nameof(Products.Id)}={id}");
            }
            return product;
        }

        public static Suppliers GetSupplierWithId(string id)
        {
            var supplier = new Suppliers();
            using (var db = new DbService())
            {
                supplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.Id)}={id}");
            }
            return supplier;
        }

        public static Customers GetCustomerWithName(string name)
        {
            var customer = new Customers();
            using (var db = new DbService())
            {
                customer = db.FirstOrDefault<Customers>($"{nameof(Customers.CustomerUserName)}='{name}'");
            }
            return customer;
        }

        public static Products GetProductWithName(string name)
        {
            var product = new Products();
            using (var db = new DbService())
            {
                product = db.FirstOrDefault<Products>($"{nameof(Products.ProductName)}='{name}'");
            }
            return product;
        }

        public static Suppliers GetSupplierWithName(string name)
        {
            var supplier = new Suppliers();
            using (var db = new DbService())
            {
                supplier = db.FirstOrDefault<Suppliers>($"{nameof(Suppliers.SupplierCompanyName)}='{name}'");
            }
            return supplier;
        }

    }
}
