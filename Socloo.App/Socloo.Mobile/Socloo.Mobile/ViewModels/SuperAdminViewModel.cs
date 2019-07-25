using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels {
    class SuperAdminViewModel {
        public bool Deleted { get; set; } = false;
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> TeachersId { get; set; }
        public List<string> CoursesId { get; set; }
    }
}
