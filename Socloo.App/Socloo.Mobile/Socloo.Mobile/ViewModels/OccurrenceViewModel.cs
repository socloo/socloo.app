using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    class OccurrenceViewModel
    {

        public int Type { get; set; }
        public string TeacherId { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
