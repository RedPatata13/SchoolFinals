using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class TeacherModel
    {
        public string TeacherID { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;

        public string UserID { get; set; } = null!;
        public UserModel User { get; set; } = null!;

        public override string ToString()
        {
            return $"{LastName ?? ""}, {FirstName ?? ""} {(MiddleName ?? "").Substring(0, 1)}.".Trim();
        }
    }
}
