using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Y2S1_INC_Compliance_proj.Data;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Repositories
{
    public class SchoolYearRepository : BaseRepository<SchoolYearModel>, ISchoolYearModelRepository
    {
        public SchoolYearRepository(AppDbContext context) : base(context)
        {
            
        }

        public SchoolYearModel GetCurrentSchoolYear()
        {
            return _context.SchoolYearModels.
                Include(sy => sy.Semesters).
                FirstOrDefault(sy => sy.IsCurrent)!;
        }
    }
}
