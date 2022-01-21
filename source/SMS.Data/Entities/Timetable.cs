using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Timetable : BaseEntity
  {
        public int TimeTableID { get; set; }
        public int ClassID { get; set; }
        public int SectionID { get; set; }
        public string WeekDay { get; set; }
        public int SubjectID { get; set; }
        public int StaffID { get; set; }
        public string Timefrom { get; set; }
        public string Timeto { get; set; }
        public int RoomID { get; set; }
    }
}
