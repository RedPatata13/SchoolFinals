using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class UserModel
    {
        public string UserID { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public UserRole UserRole { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActivated {  get; set; }

        public string CreatorId { get; set; } = null!;
        public UserModel Creator { get; set; } = null!; // Reference to the creator of the user, if applicable
    }

    public enum UserRole
    {
        Admin,
        Teacher,
        Student
    }
}
