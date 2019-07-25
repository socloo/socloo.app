using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.ViewModels {
    class TestViewModel {
        public List<string> TeachersId { get; set; }
        public List<string> StudentsId { get; set; }
        public double TimeMax { get; set; }
        public string PictureId { get; set; }
        public List<string> QuestionsId { get; set; }
        public int Type { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
