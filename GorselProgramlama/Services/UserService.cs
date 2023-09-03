using GorselProgramlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public class UserService
    {
        public static List<object> GetAllUsers()
        {
            var allUserList= new List<object>();
            using (var db = new DbService())
            {
                var adminList = db.GetList<Admins>();
                var supplierList = db.GetList<Suppliers>();
                var customerList = db.GetList<Customers>();
                allUserList.Add(adminList);
                allUserList.Add(supplierList);
                allUserList.Add(customerList);  
            }
            return allUserList;
        }
    }
}
