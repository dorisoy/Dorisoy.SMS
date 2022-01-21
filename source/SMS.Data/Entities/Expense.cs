using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Expense : BaseEntity
  {
        public int ExpenseID { get; set; }
        public string ExpenseHeadTitle { get; set; }
        public string ExpenseName { get; set; }
        public string InvoiceNumber { get; set; }
        public string ExpenseDate { get; set; }
        public decimal ExpenseAmount { get; set; }
        public string ExpenseDescription { get; set; }
    }
}
