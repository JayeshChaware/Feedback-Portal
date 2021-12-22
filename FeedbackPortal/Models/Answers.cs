using System;

namespace FeedbackPortal.Models
{
    public class Answers
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerDate { get; set; }
        public int Warning { get; set; }
    }
}
