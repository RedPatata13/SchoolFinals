using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    /// <summary>
    /// Model containing a single class section's term information.
    /// </summary>
    public class ClassSectionTermDataModel
    {
        public string ClassSectionTermDataId { get; set; } = null!;
        
        public string ClassSectionId { get; set; } = null!;
        public ClassSectionModel ClassSection { get; set; } = null!;

        public string TermId { get; set; } = null!;
        public TermModel Term { get; set; } = null!;

        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel SchoolYear { get; set; } = null!;

        public ICollection<CourseModel_Assigned> AssignedCourses { get; set; } = null!;
        public ICollection<ClassSectionRegistration> Entrees { get; set; } = null!;
        public DateTime DateCreated { get; set; } = DateTime.MinValue;
    }

    //public enum TermType { Default, Active, Archived }
}
