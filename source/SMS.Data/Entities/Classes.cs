using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Classes : BaseEntity
  {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string SectionTitle { get; set; }
        public string HeadTeacher { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
