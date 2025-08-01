using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Repositories.Interfaces
{
    public interface ISchoolYearModelRepository : IBaseRepository<SchoolYearModel>
    {
        SchoolYearModel GetCurrentSchoolYear();
    }


}
