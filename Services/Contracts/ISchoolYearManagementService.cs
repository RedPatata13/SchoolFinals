using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.Contracts
{
    public interface ISchoolYearManagementService : IDisposable
    {
        void ConcludeCurrentSchoolYear();
        SchoolYearModel CreateNewSchoolYear(bool concludeCurrentSchoolYear = false);
    }
}
