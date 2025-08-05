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
    public class CourseRepository : BaseRepository<CourseModel>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
