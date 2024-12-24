using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class UserDto
    {
        public string Cd { get; set; }
        public string Abbr { get; set; }
        public string Grp { get; set; }
        public string UPWD { get; set; }
        public string UName { get; set; }
        public string POS_U_Typ { get; set; }
        public decimal POS_U_MaxDisc { get; set; }
        public string POS_U_Cancel { get; set; }
        public string POS_U_FOC { get; set; }
        public string POS_U_ReissueBill { get; set; }
        public string POS_U_ReceiptOff { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public string EntryBy { get; set; }
        public DateTime? EntryDt { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDt { get; set; }
        public string UPWD_N { get; set; }
    }

}
