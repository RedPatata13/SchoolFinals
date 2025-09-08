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
    public class AssignedCoursesRepository : BaseRepository<CourseModel_Assigned>, IAssignedCoursesRepository
    {
        public AssignedCoursesRepository(AppDbContext context) : base(context)
        {
        }

        public ICollection<CourseModel_Assigned> GetByClassSectionId(string classSectionId)
        {
            return _context.AssignedCourses
                .Where(ac => ac.SectionId == classSectionId)
                .Include(ac => ac.Course)
                .Include(ac => ac.Teacher)
                .Include(ac => ac.Section)
                .AsNoTracking()
                .ToList();
        }

        public ICollection<CourseModel_Assigned> GetByTeacherIdForTerm(string teacherId, string TermId)
        {
            return _context.AssignedCourses
                .Where(ac => ac.TeacherId == teacherId && ac.SemesterId == TermId)
                .Include(ac => ac.Course)
                .Include(ac => ac.Teacher)
                .Include(ac => ac.Section)
                .Include(ac => ac.Semester)
                .Include(ac => ac.Registrations)
                    .ThenInclude(r => r.Student)
                .Include(ac => ac.Registrations)
                    .ThenInclude(r => r.AssignedCourseGrade)
                        .ThenInclude(acg => acg.Student)
                .AsNoTracking()
                .ToList();
        }
    }
}
