using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class CourseModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; } = false;

        public List<string> StudentsId { get; set; }

        public List<string> TeachersId { get; set; }

        public List<string> CoordinatorsId { get; set; }

        public int Grade { get; set; }
        public String Section { get; set; }
        public String SubjectBranch { get; set; }
    }
}
