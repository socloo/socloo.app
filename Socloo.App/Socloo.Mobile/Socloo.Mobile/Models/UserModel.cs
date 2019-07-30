using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models
{
    class UserModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureId { get; set; }
        public bool Deleted { get; set; } = false;
        public string CalendarId { get; set; }
    }
}
