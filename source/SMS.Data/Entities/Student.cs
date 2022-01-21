using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
    public class Student : BaseEntity
  {
        public int StudentID { get; set; }
        public string StudentCode { get; set; }
        public string StudentType { get; set; }
        public string ClassID { get; set; }
        public string SectionID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string StudentGender { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int StudentAge { get; set; }
        public string StudentContact { get; set; }
        public string StudentCitizenship { get; set; }
        public string StudentAddress { get; set; }
        public string FName { get; set; }
        public string FOccupation { get; set; }
        public string FContact { get; set; }
        public string MName { get; set; }
        public string MOccupation { get; set; }
        public string MContact { get; set; }
        public string StudentINTID { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string PrevSchool { get; set; }
        public string OtherNotes { get; set; }
        public string StudentStatus { get; set; }

        public string StudentImage { get; set; }

    }
}
