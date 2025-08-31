using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.SY_Services.Contracts
{
    public interface IProgramTermDataGenerator
    {
        ClassSectionTermDataModel GenerateProgramTermData(string classSectionId, string schoolYearId, string termId, bool nullNonStrings = true);
    }
}
