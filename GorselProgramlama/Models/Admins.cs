using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class Admins:BaseEntity
    {
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
