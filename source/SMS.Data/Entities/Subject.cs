using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Subject : BaseEntity
  {
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectTitle { get; set; }
        public string SubjectType { get; set; }
        public int ClassID { get; set; }

    }
}
