using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class IncomeHead : BaseEntity
  {
        public int IncomeHeadID { get; set; }
        public string IncomeHeadTitle { get; set; }
        public string IncomeHeadDescription { get; set; }
    }
}
