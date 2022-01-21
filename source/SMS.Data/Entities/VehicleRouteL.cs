using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class VehicleRouteL : BaseEntity
  {
    public int VehicleRouteID { get; set; }
    public int RouteID { get; set; }
    public int VehicleID { get; set; }
  }
}
