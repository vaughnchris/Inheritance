using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curiculum
{
    public class Course
    {
        public string? CourseId { get; set; }
        public string? CourseTitle { get; set; }
        public decimal Units { get; set; }
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
