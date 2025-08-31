using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Services.SY_Services.Contracts;

namespace Finals.Services.SY_Services
{
    public class ClassSectionTermDataGenerator : IClassSectionTermDataGenerator
    {
        public ClassSectionTermDataModel GenerateProgramTermData(string classSectionId, string schoolYearId, string termId, bool nullNonStrings = true)
        {
            return new ClassSectionTermDataModel()
            {
                ClassSectionTermDataId = Guid.NewGuid().ToString(),
                ClassSectionId = classSectionId,
                SchoolYearId = schoolYearId,
                TermId = termId,
                DateCreated = DateTime.UtcNow,
            };
        }
    }
}
