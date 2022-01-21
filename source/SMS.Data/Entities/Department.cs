using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Department : BaseEntity
  {
        public int DepartmentID { get; set; }
        public string DepartmentTitle { get; set; }
    }
}
