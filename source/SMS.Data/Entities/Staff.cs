using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Staff : BaseEntity
  {
        public int StaffID { get; set; }
        public string StaffCode { get; set; }
        public int RoleID { get; set; }
        public int DepartmentID { get; set; }
        public int DesignationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string StaffGender { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int StaffAge { get; set; }
        public string StaffPhone { get; set; }
        public string StaffCitizenship { get; set; }
        public string StaffAddress { get; set; }
        public string StaffDegree { get; set; }
        public string StaffQualification { get; set; }
        public string StaffExperience { get; set; }
        public string StaffINTID { get; set; }
        public decimal StaffSalary { get; set; }
        public string StaffContract { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string StaffImage { get; set; }

    }
}
