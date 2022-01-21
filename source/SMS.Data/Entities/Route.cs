using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Route : BaseEntity
  {
        public int RouteID { get; set; }
        public string RouteTitle { get; set; }
        public double RouteFare { get; set; }
    }
}
