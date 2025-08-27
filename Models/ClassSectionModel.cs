using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{ 
    public class ClassSectionModel
    {
        public string SectionID { get; set; } = null!;
        public string SectionName { get; set;} = null!;
        public int YearLevel { get; set; } = 0;
        public string ProgramId { get; set; } = null!;
        public ProgramModel Program { get; set; } = null!;
        public ICollection<ClassBatchModel> Batches { get; set;} = null!;
        public ICollection<ClassSectionTransitionModel> IncomingTransition { get; set; } = null!;
        public ICollection<CourseModel> DefaultCourses { get; set;} = null!;
        //public ICollection<SemesterModel> Semesters { get; set; } = null!;
    }
}
