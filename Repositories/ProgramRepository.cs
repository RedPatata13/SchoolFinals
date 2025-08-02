using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Y2S1_INC_Compliance_proj.Data;

namespace Finals.Repositories
{
    public class ProgramRepository : BaseRepository<ProgramModel>, IProgramRepository
    {
        public ProgramRepository(AppDbContext context) : base(context) { }

        public override IEnumerable<ProgramModel> GetAll()
        {
            return _context.Program
                .Include(p => p.CreatedBy)
                .Include(p => p.LastEditedBy)
                .Include(p => p.ClassSections)
                .ToList();
        }
    }
}
