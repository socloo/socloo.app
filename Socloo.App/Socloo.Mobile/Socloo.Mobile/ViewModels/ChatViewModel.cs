using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class ChatViewModel
    {

        public bool Deleted { get; set; } = false;
        public List<string> UsersId { get; set; }
        
        public List<string> MessagesId { get; set; }
        public string ChatName { get; set; }
        public int ChatType { get; set; }
    }
}
