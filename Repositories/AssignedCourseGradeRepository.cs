using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Data;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Finals.Repositories
{
    public class AssignedCourseGradeRepository : BaseRepository<AssignedCourseGrade>, IAssignedCourseGradesRepository
    {
        public AssignedCourseGradeRepository(AppDbContext context) : base(context)
        {
        }

        public ICollection<AssignedCourseGrade> GetByStudentIdForTerm(string studentId, string termId)
        {
            if (!_context.Semesters.Any(t => t.TermId == termId))
                throw new ArgumentException("Invalid Term Id");

            if (!_context.StudentModels.Any(s => s.StudentID == studentId))
                throw new ArgumentException("Invalid Student Id");


            var studentGrades = _context.AssignedCourseRegistrations
                    .Where(acr => acr.UserId == studentId && termId == acr.TermId)
                    .Include(acr => acr.AssignedCourseGrade)
                        .ThenInclude(acg => acg.Student)
                    .Select(acr => acr.AssignedCourseGrade)
                    .ToList();

            return studentGrades;
        }

        public ICollection<AssignedCourseGrade> GetByAssignedCourseId(string assignedCourseId)
        {
            var assignedCourse = _context.AssignedCourses
                .Include(ac => ac.Registrations)
                    .ThenInclude(acr => acr.AssignedCourseGrade)
                        .ThenInclude(acg => acg.Student)
                .FirstOrDefault(ac => ac.AssignedCourseModelId == assignedCourseId)
                    ?? throw new ArgumentException("Invalid Assigned Course Id");

            return assignedCourse.Registrations.Select(acr => acr.AssignedCourseGrade).ToList();
        }
    }
}
