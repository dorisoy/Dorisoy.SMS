using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Role : BaseEntity
  {
        public int RoleID { get; set; }
        public string RoleTitle { get; set; }
    }
}
