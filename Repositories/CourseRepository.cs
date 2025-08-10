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
    public class CourseRepository : BaseRepository<CourseModel>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }

        public override IEnumerable<CourseModel> GetAll()
        {
            return _context.Courses.Include(c => c.Creator).AsNoTracking().ToList();
        }
    }
}
