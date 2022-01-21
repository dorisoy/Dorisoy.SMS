using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Receptionist : BaseEntity
  {
        public int VisitorID { get; set; }
        public string PurposeVisit { get; set; }
        public string VisitorDetails { get; set; }
        public string WhomToMeet { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        public DateTime InsertTime { get; set; }
        public int NumberOfVisitors { get; set; }
    }
}
