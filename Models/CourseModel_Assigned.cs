using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class CourseModel_Assigned
    {
        public string AssignedCourseModelId { get; set; } = null!;
        public DateTime DateAssigned { get; set; }
        public string CourseId { get; set; } = null!;
        public CourseModel Course { get; set; } = null!;
        
        public string TeacherId { get; set; } = null!;
        public TeacherModel Teacher { get; set; } = null!;

        public string AssignedId { get; set; } = null!;
        public UserModel AssignedBy { get; set; } = null!;

        public string SemesterId { get; set; } = null!;
        public SemesterModel Semester { get; set; } = null!;

        public string SectionId { get; set; } = null!;
        public ClassSectionModel Section { get; set; } = null!;

        [NotMapped]
        public ICollection<AssignedCourseRegistration> Registrations { get; set; } = new List<AssignedCourseRegistration>();

        public AssignedCourseStatus Status { get; set; } = AssignedCourseStatus.Default;

        public ICollection<VenueModel> Schedules { get; set; } = new List<VenueModel>();
    }

    public enum AssignedCourseStatus
    {
        Default, Active, Archived
    }
}
