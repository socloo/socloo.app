using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class CalendarViewModel
    {

        public bool Deleted { get; set; } = false;

        public string UserId { get; set; }
        public List<string> OccurrencesId { get; set; }
    }
}
