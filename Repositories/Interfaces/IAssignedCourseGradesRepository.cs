using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Repositories.Interfaces
{
    public interface IAssignedCourseGradesRepository : IBaseRepository<AssignedCourseGrade>
    {
        ICollection<AssignedCourseGrade> GetByStudentIdForTerm(string studentId, string termId);
        ICollection<AssignedCourseGrade> GetByAssignedCourseId(string assignedCourseId);

        void UpdateGrade(string gradeId, CourseGrade newGrade);
    }
}
