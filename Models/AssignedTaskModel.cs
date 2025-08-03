using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class AssignedTaskModel
    {
        public string AssignedTaskId { get; set; } = null!;
        public string AssignedToId { get; set; } = null!;
        public UserModel Assignee { get; set; } = null!;

        public string AssignedById { get; set; } = null!;
        public UserModel AssignedBy { get; set; } = null!;

        public string TaskId { get; set; } = null!;
        public GradedTaskModel Task { get; set; } = null!;

        public DateTime DateAssigned { get; set; }
        public DateTime? DateGraded { get; set; } = null;
        public AssignedTaskStatus Status { get; set; } = AssignedTaskStatus.Default;
        public double Grade { get; set; }
    }

    public enum AssignedTaskStatus
    {
        Default, Graded, Ungraded, Archived
    }
}
