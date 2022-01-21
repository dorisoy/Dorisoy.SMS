using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Event : BaseEntity
  {
        public int EventID { get; set; }
        public string EventTitle { get; set; }
        public int EventTypeID { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Audience { get; set; }
        public string ClassID { get; set; }
        public string SectionID { get; set; }
        public string EventDescription { get; set; }
        public int StaffID { get; set; }
    }
}
