using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    class MessageViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime DataTime { get; set; }
        public string MessageText { get; set; }
        public string ChatId { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
