using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Vehicle : BaseEntity
  {
        public int VehicleID { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleDriver { get; set; }
        public string DriverLicense { get; set; }
        public string DriverContact { get; set; }
        public string VehicleNote { get; set; }
    }
}
