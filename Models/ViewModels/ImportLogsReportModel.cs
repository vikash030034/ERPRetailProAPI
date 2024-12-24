using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ImportLogsReportModel
    {
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string importedBy { get; set; } = string.Empty;

    }
}
