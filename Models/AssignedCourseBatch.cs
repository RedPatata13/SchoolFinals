using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Finals.Models
{
    public class AssignedCourseBatch
    {
        public string Acb_Id { get; set; } = null!;
        public string AssignedCourseId { get; set; } = null!;
        public CourseModel_Assigned AssignedCourse { get; set; } = null!;

        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel Schoolyear { get; set; } = null!;
        public ICollection<StudentModel> Students { get; set; } = null!;
    }
}
