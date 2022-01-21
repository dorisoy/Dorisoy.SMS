using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Schedule : BaseEntity
  {
        public int ScheduleID { get; set; }
        public string AcyCode { get; set; }
        public int StrandID { get; set; }
        public int GradeID { get; set; }
        public int SectionID { get; set; }
        public string RoomCode { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Timefrom { get; set; }
        public string Timeto { get; set; }

        public string StrandTitle { get; set; }
        public string SectionGrade { get; set; }
        
    }
}
