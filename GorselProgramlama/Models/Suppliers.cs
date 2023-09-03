using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class Suppliers:BaseEntity
    {
        public string SupplierUserName { get; set; }
        public string SupplierPassword { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierStorages { get; set; }
    }
}
