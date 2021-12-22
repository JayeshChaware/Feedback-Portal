using System;

namespace FeedbackPortal.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public Enum.StarRating Rating { get; set; }
        public string Comment { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int Warning { get; set; }
    }
}
