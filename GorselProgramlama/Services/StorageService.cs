using GorselProgramlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public static class StorageService
    {
        public static List<string> GetOwnerList(string type)
        {
            var list = new List<string>();
            switch (type)
            {
                case "Müşteri":
                    var customerList = new List<Customers>();
                    using (var db = new DbService())
                    {
                        customerList = db.GetList<Customers>();
                    }
                    foreach(var customer in customerList)
                    {
                        list.Add(customer.CustomerUserName);
                    }
                    break;
                case "Tedarikçi":
                    var supplierList = new List<Suppliers>();
                    using (var db = new DbService())
                    {
                        supplierList = db.GetList<Suppliers>();
                    }
                    foreach (var supplier in supplierList)
                    {
                        list.Add(supplier.SupplierUserName);
                    }
                    break;
            }
            return list;
        }
    }
}
