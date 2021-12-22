using System;

namespace FeedbackPortal.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime LaunchDate { get; set; }
        public int Warning { get; set; }
    }
}
