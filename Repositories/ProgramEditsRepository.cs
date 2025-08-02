using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Finals.Data;

namespace Finals.Repositories
{
    public class ProgramEditsRepository : BaseRepository<ProgramModel_Edits>, IProgramEditsRepository
    {
        public ProgramEditsRepository(AppDbContext context) : base(context) { }

        public IEnumerable<ProgramModel_Edits> GetAllProgramEditsById(string programId)
        {
            return _context.ProgramEdits
                .Where(e => e.ProgramId == programId)
                .Include(e => e.EditedBy)
                .Include(e => e.ProgramEdited)
                .OrderByDescending(e => e.EditedAt)
                .ToList();
        }

        public ProgramModel_Edits? GetLatestProgramEdit(string programId)
        {
            return _context.ProgramEdits
                .Where(e => e.ProgramId == programId)
                .Include(e => e.EditedBy)
                .Include(e => e.ProgramEdited)
                .OrderByDescending(e => e.EditedAt)
                .FirstOrDefault();
        }
    }
}
