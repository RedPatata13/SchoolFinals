using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2S1_INC_Compliance_proj.Models
{
    public class UserModel
    {
        public string UserID { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public UserRole UserRole { get; set; }
        public bool IsActivated {  get; set; }
    }

    public enum UserRole
    {
        Admin,
        Teacher,
        Student
    }
}
