using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class UserAccount : BaseEntity
  {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int StaffID { get; set; }
        public int StudentID { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountStatus { get; set; }
    }
}
