using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels
{
    public class AnswerTFViewModel
    {
        public bool Deleted { get; set; } = false;

        public string QuestionId { get; set; }
        public bool Correct { get; set; }
    }
}
