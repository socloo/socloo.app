using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class AnswerSAViewModel
    {
        public bool Deleted { get; set; } = false;
        public string Text { get; set; }
        public string QuestionId { get; set; }
    }
}
