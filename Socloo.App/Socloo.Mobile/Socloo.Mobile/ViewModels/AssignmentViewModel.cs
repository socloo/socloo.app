using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class AssignmentViewModel
    {

        public bool Deleted { get; set; } = false;

        public List<string> TeachersId { get; set; }
        public List<string> StudentsId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Info { get; set; }
        public string FileId { get; set; }
    }
}
