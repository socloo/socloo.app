using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models
{
    class PortfolioModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public string Interests { get; set; }
        public string References { get; set; }
        public string GeneralInfo { get; set; }
        public string Certification { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
