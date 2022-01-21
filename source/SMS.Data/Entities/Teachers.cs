using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
  public class Teachers : BaseEntity
  {
        public int TeacherID { get; set; }
        public string TeacherCode { get; set; }
        public int RoleID { get; set; }
        public int DesignationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string TeacherGender { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int TeacherAge { get; set; }
        public string TeacherContact { get; set; }
        public string TeacherCitizenship { get; set; }
        public string TeacherAddress { get; set; }
        public string UnderGraduation { get; set; }
        public string GraduationDegree { get; set; }
        public string TeacherSpecialization { get; set; }
        public string TeacherINTID { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string PrevSchool { get; set; }
        public string OtherNotes { get; set; }
    }
}
