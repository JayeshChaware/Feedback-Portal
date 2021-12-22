using System;

namespace FeedbackPortal.Models
{
    public class Questions
    {
        public int QuestionID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public string Question { get; set; }
        public DateTime QuestionDate { get; set; }
        public int Warning { get; set; }
    }
}
