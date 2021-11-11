using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public enum GradeType {Assignment, Quiz, Test, Lab, Other}
    public enum PhoneType {Home, Work, Cell, Other}
    public class Phone
    {
        public string StudentId { get; set; } = string.Empty;
        public PhoneType PhoneType;
        public string PhoneNumber { get; set; }
        public Phone(string id, string number, PhoneType type)
        {
            this.StudentId = id;
            this.PhoneNumber = number;
            this.PhoneType = type;
        }
    }
    public class Student
    {
        public string StudentId {  get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty ;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Phone> PhoneNumbers { get; set; }
        public Student(List<Phone>? phones = null) 
        { 
            if(phones != null)
                this.PhoneNumbers = phones;
            else
                this.PhoneNumbers = new List<Phone>(); 
        }
        public Student(string id, string fName, string lName, string email, 
            List<Phone>? phones = null)
        {
            this.StudentId= id;
            this.FirstName = fName;
            this.LastName = lName;
            this.Email = email;
            if(phones != null)
                this.PhoneNumbers = phones;
            else
                this.PhoneNumbers = new List<Phone>();
        }

    }
}
