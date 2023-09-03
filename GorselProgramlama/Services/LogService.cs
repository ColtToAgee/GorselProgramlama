using GorselProgramlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public static class LogService
    {
        public static void CreateErrorLog(Exception ex)
        {
            var newErrorLog = new ErrorLogs()
            {
                LogSource=ex.Source,
                LogMessage = ex.Message,
                CreatedByUser = StaticEntities.ActiveUsername,
                CreatedTime = DateTime.Now.ToString(),
                RowStateId = 1
            };
            using(var db = new DbService())
            {
                db.AddOrUpdateEntity<ErrorLogs>(newErrorLog);
            }
        }
    }
}
