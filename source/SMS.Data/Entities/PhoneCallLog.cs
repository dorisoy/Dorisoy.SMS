using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class PhoneCallLog : BaseEntity
  {
        public int PhoneCallLogID { get; set; }
        public string PhoneCallerName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime PhoneCallDate { get; set; }
        public string PhoneDescription { get; set; }
        public string CallDuration { get; set; }
        public string CallType { get; set; }
    }
}
