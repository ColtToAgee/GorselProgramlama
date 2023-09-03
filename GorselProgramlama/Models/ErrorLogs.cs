using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Models
{
    public class ErrorLogs:BaseEntity
    {
        public string LogSource { get; set; }
        public string LogMessage { get; set; }
    }
}
