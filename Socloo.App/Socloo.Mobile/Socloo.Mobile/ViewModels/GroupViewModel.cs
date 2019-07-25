using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    class GroupViewModel
    {
        public List<string> StudentsId { get; set; }

        public List<string> TeachersId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string PictureId { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
