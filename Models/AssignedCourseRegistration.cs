using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class AssignedCourseRegistration
    {
        public string AssignedCourseRegistrationId { get; set; } = null!;
        public string AssignedCourseId { get; set; } = null!;
        public CourseModel_Assigned AssignedCourse { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public StudentModel Student { get; set; } = null!;
        public DateTime RegistrationDate { get; set; } = DateTime.MinValue;

        public string AssignedCourseGradeId { get; set; } = null!;
        public AssignedCourseGrade AssignedCourseGrade { get; set; } = null!;
    }
}
