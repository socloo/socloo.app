using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels {
    class StudentViewModel {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> CoursesId { get; set; }
        public List<string> GroupsId { get; set; }
        public List<string> TeachersId { get; set; }
        public string PortfolioId { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
