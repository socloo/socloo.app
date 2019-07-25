using System;
using System.Collections.Generic;
using System.Text;

namespace Socloo.Mobile.Models {
    class TestModel {
        public string Id { get; set; }
        public List<string> TeachersId { get; set; }
        public List<string> StudentsId { get; set; }
        public double TimeMax { get; set; }
        public string PictureId { get; set; }
        public List<string> QuestionsId { get; set; }
        public int Type { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
