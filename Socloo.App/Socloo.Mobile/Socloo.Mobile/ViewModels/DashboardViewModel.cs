using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class DashboardViewModel
    {
        public bool Deleted { get; set; } = false;

        public List<string> UsersId { get; set; }

        public List<string> PostsId { get; set; }
    }
}
