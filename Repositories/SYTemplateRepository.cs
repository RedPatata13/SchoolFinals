using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Data;
using Finals.Repositories.Interfaces;
using Finals.Services.SY_Services;

namespace Finals.Repositories
{
    public class SYTemplateRepository : BaseRepository<SYTemplate>, ISYTemplateRepository
    {
        public SYTemplateRepository(AppDbContext context) : base(context)
        {

        }

        public SYTemplate? GetActiveTemplate()
        {
            return _context.SYTemplates.FirstOrDefault(t => t.IsActive);
        }
    }
}
