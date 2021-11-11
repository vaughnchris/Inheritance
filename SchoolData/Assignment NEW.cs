using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public int AssignmentType { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Points { get; set; }
        public string Introduction { get; set; } = "";
        public Assignment() { }
        public Assignment(int id, int type, string name, string description, int points, string intro)
        {
            AssignmentId = id;
            AssignmentType = type;
            Name = name;
            Description = description;
            Points = points;
            Introduction = intro;
        }
    }
}
