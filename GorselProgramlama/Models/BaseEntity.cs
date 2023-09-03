using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedTime { get; set; }= DateTime.Now.ToString();
        public string DeletedByUser { get; set; }
        public string DeletedTime { get; set; }
        public int RowStateId { get; set; } = 1;
    }
}
