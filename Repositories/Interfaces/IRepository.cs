using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Repositories.Interfaces
{
    public interface IRepository : IDisposable
    {
        IUserModelRepository Users { get; }
        ISchoolYearModelRepository SchoolYears { get; }

        IProgramRepository Programs { get; }
        IProgramEditsRepository ProgramEdits { get; }
        IClassSectionEditRepository ClassSectionEdits { get; }
        IClassSectionRepository ClassSections { get; }
        IClassSectionTransitionRepository ClassSectionTransitions { get; }
        IClassBatchRepository ClassBatches { get; }
        IClassEntryRepository ClassEntries { get; }
        void SaveChanges();
    }
}
