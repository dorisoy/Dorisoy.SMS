using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class ExpenseHead : BaseEntity
  {
        public int ExpenseHeadID { get; set; }
        public string ExpenseHeadTitle { get; set; }
        public string ExpenseHeadDescription { get; set; }
    }
}
