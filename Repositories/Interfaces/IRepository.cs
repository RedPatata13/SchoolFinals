using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Services.SY_Services;

namespace Finals.Repositories.Interfaces
{
    public interface IRepository : IDisposable
    {
        IUserModelRepository Users { get; }
        ITeacherRepository Teacher { get; }
        ISemesterRepository Semesters { get; }
        ISchoolYearModelRepository SchoolYears { get; }
        ISYTemplateRepository SYTemplates { get; }
        IProgramRepository Programs { get; }
        IProgramEditsRepository ProgramEdits { get; }
        IClassSectionEditRepository ClassSectionEdits { get; }
        IClassSectionRepository ClassSections { get; }
        IClassSectionTransitionRepository ClassSectionTransitions { get; }
        IClassBatchRepository ClassBatches { get; }
        IClassEntryRepository ClassEntries { get; }
        ICourseTemplateRepository CourseTemplates { get; }
        IGradesClassificationRepository GradesClassifications { get; }
        IGradesTreeRepository GradesTrees { get; }
        ICourseRepository Courses { get; }
        IAssignedCoursesRepository AssignedCourses { get; } 
        void SaveChanges();
    }
}
