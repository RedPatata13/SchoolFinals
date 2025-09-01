using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Services.SY_Services;

namespace Finals.Repositories.Interfaces
{
    public interface ISYTemplateRepository : IBaseRepository<SYTemplate>
    {
        SYTemplate? GetActiveTemplate();
    }
}
