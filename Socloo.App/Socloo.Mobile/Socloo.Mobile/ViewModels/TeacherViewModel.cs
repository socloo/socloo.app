using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    class TeacherViewModel
    {
        public bool Deleted { get; set; } = false;
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> CoursesId { get; set; }
        public List<string> GroupsId { get; set; }
        public List<string> Subject { get; set; }
    }
}
