using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class StudentModel
    {
        public string StudentID { get; set; } = null!;


        public string UserId { get; set; } = null!;
        public UserModel User { get; set; } = null!;
    }
}
