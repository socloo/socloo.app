using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models {
    class QuestionModel {
        public string Id { get; set; }
        public string Text { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
