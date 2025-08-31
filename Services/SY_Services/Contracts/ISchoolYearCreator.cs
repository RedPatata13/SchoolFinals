using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.SY_Services.Contracts
{
    public interface ISchoolYearCreator
    {
        SchoolYearModel CreateSchoolYear(SYTemplate template, bool concludeCurrentSchoolYear = false);
    }
}
