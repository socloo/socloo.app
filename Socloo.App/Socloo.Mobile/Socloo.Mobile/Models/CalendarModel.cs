using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class CalendarModel
    {

        public string Id { get; set; }
        public bool Deleted { get; set; } = false;

        public string UserId { get; set; }
        public List<string> OccurrencesId { get; set; }
    }
}
