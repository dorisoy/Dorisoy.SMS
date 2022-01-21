using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Attendance : BaseEntity
  {
        public int AttendanceID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public int SectionID { get; set; }
        public string AttendanceStatus { get; set; }
        public DateTime AttendanceDate { get; set; }

    }
}
