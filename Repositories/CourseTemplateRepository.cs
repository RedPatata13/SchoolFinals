using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Data;
using Finals.Models;
using Finals.Repositories.Interfaces;

namespace Finals.Repositories
{
    public class CourseTemplateRepository : BaseRepository<CourseTemplateModel>, ICourseTemplateRepository
    {
        public CourseTemplateRepository(AppDbContext context) : base(context)
        {
        }

        public ICollection<CourseTemplateModel> GetByProgramId(string programId)
        {
            return _context.CourseTemplates
                .Where(ct => ct.ProgramId == programId)
                .ToList();
        }
    }
}
