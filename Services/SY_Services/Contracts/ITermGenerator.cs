using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Services.SY_Services.Contracts
{
    public interface ITermGenerator
    {
        ICollection<TermModel> GenerateTerms(string schoolYearId, params string[] termNames);
        void AddExtraTermsToStandardTerm(TermModel termModel, params string[] extraTermNames);
    }
}
