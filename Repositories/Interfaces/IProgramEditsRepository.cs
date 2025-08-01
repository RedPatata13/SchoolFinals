using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Repositories.Interfaces
{
    public interface IProgramEditsRepository : IBaseRepository<ProgramModel_Edits>
    {
        IEnumerable<ProgramModel_Edits> GetAllProgramEditsById(string programId);
        ProgramModel_Edits? GetLatestProgramEdit(string programId);
    }
}
