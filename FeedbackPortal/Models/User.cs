using System;

namespace FeedbackPortal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Enum.Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public Enum.Roles RoleID { get; set; }
        public int Warning { get; set; }
    }
}
