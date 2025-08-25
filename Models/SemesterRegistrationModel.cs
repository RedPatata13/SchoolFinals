using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class SemesterRegistrationModel
    {
        public string SemesterRegistrationId { get; set; } = null!;
        public string SemesterId { get; set; } = null!;
        public SemesterModel Semester { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public StudentModel Student { get; set; } = null!;
        public DateTime RegistrationDate { get; set; } = DateTime.MinValue;
    }
}
