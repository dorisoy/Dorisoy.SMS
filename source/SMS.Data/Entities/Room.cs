using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Room : BaseEntity
  {
        public int RoomID { get; set; }
        public string RoomCode { get; set; }
        public string RoomCapacity { get; set; }
        public string RoomType { get; set; }
    }
}
