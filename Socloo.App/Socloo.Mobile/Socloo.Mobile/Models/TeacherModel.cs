using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    class TeacherModel
    {

        public string Id { get; set; }

        public string UserId { get; set; }

        public List<string> CoursesId { get; set; }

        public List<string> GroupsId { get; set; }

        public List<string> Subject { get; set; }

        public bool Deleted { get; set; } = false;
    }
}
