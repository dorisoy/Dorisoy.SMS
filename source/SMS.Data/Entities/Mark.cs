using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Mark : BaseEntity
  {
        public int MarkID { get; set; }
        public int AcyID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public decimal FirstQuarter { get; set; }
        public decimal SecondQuarter { get; set; }
        public decimal Average { get; set; }
        public string Remarks { get; set; }
        public int ClassID { get; set; }
        public int SectionID { get; set; }
    }
}
