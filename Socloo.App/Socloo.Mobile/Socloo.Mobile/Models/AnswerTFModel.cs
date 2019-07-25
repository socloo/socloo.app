using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile
{
    public class AnswerTFModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; } = false;

        public string QuestionId { get; set; }
        public bool Correct { get; set; }
    }
}
