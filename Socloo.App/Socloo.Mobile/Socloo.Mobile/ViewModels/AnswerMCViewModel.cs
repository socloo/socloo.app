using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class AnswerMCViewModel
    {
        public bool Deleted { get; set; } = false;
        public string Text { get; set; }
        public string QuestionId { get; set; }
        public bool Correct { get; set; }
        public string Image { get; set; }
    }
}
