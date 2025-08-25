using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class ClassSectionRegistration
    {
        public string ClassSectionRegistrationId { get; set; } = null!;
        public string ClassSectionId { get; set; } = null!; 
        public ClassSectionModel ClassSection { get; set; } = null!; 
        public string UserId { get; set; } = null!; 
        public StudentModel Student { get; set; } = null!;
        public DateTime RegistrationDate { get; set; } = DateTime.MinValue;
    }
}
