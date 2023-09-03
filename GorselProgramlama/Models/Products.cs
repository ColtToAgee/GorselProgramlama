using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class Products:BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductSupplier { get; set; }
        public double ProductCost { get; set; }
        public string ProductCategory { get; set; } 
    }
}
