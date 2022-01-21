using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class EventType : BaseEntity
  {
        public int EventTypeID { get; set; }
        public string EventTypeTitle { get; set; }
    }
}
