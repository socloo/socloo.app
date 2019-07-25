using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class AnswerSAModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; } = false;
        public string Text { get; set; }
        public string QuestionId { get; set; }
    }
}
