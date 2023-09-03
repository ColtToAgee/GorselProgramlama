using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class Storages:BaseEntity
    {
        public string StorageName { get; set; }
        public string StorageOwnerType { get; set; }
        public string StorageOwnerUsername { get; set; }
        public string StorageLocation { get; set; }
    }
}
