﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models
{
    class PostModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Type { get; set; }
        public DateTime PostDate { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
