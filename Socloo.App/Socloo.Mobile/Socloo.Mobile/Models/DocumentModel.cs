using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class DocumentModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; } = false;
        public string FileId { get; set; }
        public List<string> UsersId { get; set; }
        public string TeacherId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
