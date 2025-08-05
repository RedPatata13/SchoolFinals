using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class GradedTaskModel
    { 
        public string TaskId { get; set; } = null!;
        public string TaskName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; } = null!;
        public GradedTaskStatus Status { get; set; } = GradedTaskStatus.Default;
        public string ClassificationId { get; set; } = null!;
        public GradesClassification GradesClassification { get; set; } = null!;

        public string CreatorId { get; set; } = null!;
        public UserModel Creator { get; set; } = null!;

        public string AssignedCourseId { get; set; } = null!;
        public CourseModel_Assigned AssignedCourse { get; set; } = null!;
        public ICollection<AssignedTaskModel> Items { get; set; } = null!;
    }

    public enum GradedTaskStatus
    {
        Default,
        Opened,
        Closed,
        Archived
    }
}
