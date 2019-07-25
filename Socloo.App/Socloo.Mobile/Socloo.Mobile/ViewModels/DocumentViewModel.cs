using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class DocumentViewModel
    {
        public bool Deleted { get; set; } = false;
        public string FileId { get; set; }
        public List<string> UsersId { get; set; }
        public string TeacherId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
