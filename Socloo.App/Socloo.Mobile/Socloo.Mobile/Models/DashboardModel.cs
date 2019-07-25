using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class DashboardModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; } = false;

        public List<string> UsersId { get; set; }

        public List<string> PostsId { get; set; }
    }
}
