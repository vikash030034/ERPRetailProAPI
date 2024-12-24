using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ErrorLogs
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAT { get; set; }
        public string LocationController { get; set; }
    }
}
