using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class StaffAttendance : BaseEntity
  {
        public int StaffAttendanceID { get; set; }
        public int StaffID { get; set; }
        public int RoleID { get; set; }
        public string AttendanceStatus { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}
