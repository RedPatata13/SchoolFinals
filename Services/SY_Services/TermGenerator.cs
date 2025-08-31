using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Models;
using Finals.Services.SY_Services.Contracts;

namespace Finals.Services.SY_Services
{
    public class TermGenerator : ITermGenerator
    {
        public void AddExtraTermsToStandardTerm(TermModel termModel, params string[] extraTermNames)
        {
            if (termModel == null)
            {
                throw new ArgumentNullException(nameof(termModel));
            }
            foreach (var extraTermName in extraTermNames)
            {
                var extraTerm = new TermModel
                {
                    TermId = Guid.NewGuid().ToString(),
                    TermName = extraTermName,
                    SchoolYearId = termModel.SchoolYearId,
                    DateStart = default(DateTime),
                    DateEnd = default(DateTime),
                    IsActive = termModel.IsActive,
                    DateCreated = DateTime.UtcNow,
                    TermType = TermType.Extra,
                    Status = TermStatus.Preparatory,
                    StandardTermId = termModel.TermId
                };
            }
        }

        public ICollection<TermModel> GenerateTerms(string schoolYearId, params string[] termNames)
        {
            return termNames.Select(name => new TermModel
            {
                TermId = Guid.NewGuid().ToString(),
                TermName = name,
                DateCreated = DateTime.UtcNow,
                DateStart = default(DateTime),
                DateEnd = default(DateTime),
                IsActive = true,
                Status = TermStatus.Preparatory,
                TermType = TermType.Standard
            }).ToList();
        }
    }
}
