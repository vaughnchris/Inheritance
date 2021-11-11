using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? Department { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? HomePhone { get; set; }
        public string? OfficePhone { get; set; }
        public string? OfficeLocation { get; set; }
        public string? OfficeHours { get; set; }
        public string? ZoomOfficeAddress { get; set; }
        public string? Notes { get; set; }
        public string? Comments { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
