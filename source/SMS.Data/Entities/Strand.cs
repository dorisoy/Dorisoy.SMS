using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Strand : BaseEntity
  {
        public int StrandID { get; set; }
        public string StrandTitle { get; set; }
        public string StrandDescription { get; set; }
    }
}
