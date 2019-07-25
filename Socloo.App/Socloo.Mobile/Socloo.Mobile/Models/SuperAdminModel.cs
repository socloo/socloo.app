using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models {
    class SuperAdminModel {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<string> TeachersId { get; set; }
        public List<string> CoursesId { get; set; }
        public bool Deleted { get; set; } = false;
    }

}
