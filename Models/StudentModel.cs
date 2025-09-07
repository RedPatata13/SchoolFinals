using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;

        public override string ToString()
        {
            var middleInitial = !string.IsNullOrWhiteSpace(MiddleName)
                ? $"{MiddleName[0]}."
                : string.Empty;

            return $"{LastName ?? string.Empty}, {FirstName ?? string.Empty} {middleInitial}".Trim();
        }

    }
}
