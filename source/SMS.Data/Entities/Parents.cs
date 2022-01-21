using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Parents : BaseEntity
  {
        public int ParentsID { get; set; }
        public string MotherName { get; set; }
        public string MotherContact { get; set; }
        public string MotherEmail { get; set; }
        public string MotherOccupation { get; set; }
        public string FatherName { get; set; }
        public string FatherContact { get; set; }
        public string FatherEmail { get; set; }
        public string FatherOccupation { get; set; }
    }
}
