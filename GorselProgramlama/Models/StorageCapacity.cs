using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class StorageCapacity:BaseEntity
    {
        public string Storage { get; set; }
        public string Product { get; set; }
        public int NumberOfProduct { get; set; }
    }
}
