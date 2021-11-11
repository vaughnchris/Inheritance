using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Instructions { get; set; } = String.Empty;
        public DateOnly Date { get; set; }  
    }
   public enum gradingMethod { points,percent};
    public class GradedAssignment:Assignment
    {
        public gradingMethod Mog { get; set; }
        public string Value { get; set; } = String.Empty;
        public string GradingRubric { get; set; } = string.Empty;
    }

}
