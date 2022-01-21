using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class AcademicYear : BaseEntity
  {
    public int AcyID { get; set; }
    public string AcyCode { get; set; }
    public string Year1 { get; set; }
    public string Year2 { get; set; }
    public string Term { get; set; }
    public string Status { get; set; }
  }
}
