using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Section : BaseEntity
  {
        public int SectionID { get; set; }
        public string SectionStrand { get; set; }
        public string SectionTitle { get; set; }
    }
}
