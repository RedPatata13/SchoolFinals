using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class CourseTemplateItem
    {
        public string ItemId { get; set; } = null!;
        public string CourseId { get; set; } = null!;
        public CourseModel Course { get; set; } = null!;
        public int Units { get; set; }

        public string TemplateId { get; set; } = null!;
        public CourseTemplateModel Template { get; set; } = null!;

        public string AssignerId { get; set; } = null!;
        public UserModel Assigner { get; set; } = null!;

        public DateTime DateAssigned { get; set; }

        public CourseTemplateItemStatus Status { get; set; } = CourseTemplateItemStatus.Unassigned;
    }

    public enum CourseTemplateItemStatus
    {
        Unassigned, Added, Removed
    }
}
