using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class SupplyHistory:BaseEntity
    {
        public string Product { get; set; }
        public string Supplier { get; set; }
        public string Customer { get; set; }
        public int ProductTotal { get; set; }
        public double OrderCost { get; set; }
        public string CustomerStorage { get; set; }
        public int IsCompleted { get; set; }

    }
}
