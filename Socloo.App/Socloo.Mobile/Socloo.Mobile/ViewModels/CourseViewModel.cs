using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class CourseViewModel
    {
        public bool Deleted { get; set; } = false;

        public List<string> StudentsId { get; set; }

        public List<string> TeachersId { get; set; }

        public List<string> CoordinatorsId { get; set; }

        public int Grade { get; set; }
        public String Section { get; set; }
        public String SubjectBranch { get; set; }
    }
}
