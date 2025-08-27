using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class ClassSectionSemesterTemplate
    {
        public string TemplateId { get; set; } = null!;
        public string ClassSectionId { get; set; } = null!;
        public ClassSectionModel ClassSection { get; set; } = null!;
        public string SemesterId { get; set; } = null!;
        public SemesterModel Semester { get; set; } = null!;
        public ICollection<CourseModel> Courses { get; set; } = null!;
    }
}
