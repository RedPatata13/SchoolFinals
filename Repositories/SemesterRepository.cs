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
    public class SemesterRepository : BaseRepository<TermModel>, ISemesterRepository
    {
        public SemesterRepository(AppDbContext context) : base(context)
        {

        }

        public TermModel? GetCurrentTerm()
        {
            return _context.Semesters.FirstOrDefault(t => t.IsActive);
        }
    }
}
