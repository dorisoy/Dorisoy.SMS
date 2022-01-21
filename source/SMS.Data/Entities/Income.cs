using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Income : BaseEntity
  {
        public int IncomeID { get; set; }
        public string IncomeHeadTitle { get; set; }
        public string IncomeName { get; set; }
        public string InvoiceNumber { get; set; }
        public string IncomeDate { get; set; }
        public decimal IncomeAmount { get; set; }
        public string IncomeDescription { get; set; }
    }
}
