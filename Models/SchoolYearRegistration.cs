using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class SchoolYearRegistration
    {
        public string SYRegistrationId { get; set; } = null!;
        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel SchoolYear { get; set;} = null!;
        public string UserId { get; set; } = null!;
        public StudentModel Student { get; set; } = null!;
        public DateTime RegistrationDate { get; set; } = DateTime.MinValue;

    }
}
