using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Finals.Data;

namespace Finals.Repositories
{
    public class ClassBatchRepository : BaseRepository<ClassBatchModel>, IClassBatchRepository
    {
        public ClassBatchRepository(AppDbContext context) : base(context)
        {
        }

        public ClassBatchModel? GetCurrentBatch(string classSectionId)
        {
            return _context.ClassBatches
                .Where(cb => cb.ClassSectionId == classSectionId && cb.ClassBatchStatus == ClassBatchStatus.Active)
                .FirstOrDefault();
        }
    }
}
