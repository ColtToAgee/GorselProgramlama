using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class Customers:BaseEntity
    {
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerStorages { get; set; }
    }
}
