using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Library : BaseEntity
  {
        public int BookID { get; set; }
        public string BookAuthor { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookClass { get; set; }
        public int BookQuantity { get; set; }
    }
}
