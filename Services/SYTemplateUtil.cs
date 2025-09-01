using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Services.SY_Services;

namespace Finals.Services
{
    public static class SYTemplateUtil
    {
        public static ICollection<TermModel> ConstructTermsFromTemplate(SYTemplate template)
        {
            if(template == null) throw new ArgumentNullException(nameof(template));
            var terms = template.TermNames.Select(tn => new TermModel() { TermName = tn }).ToList();
            var termMap = terms.ToDictionary(terms => terms.TermName, terms => terms);

            foreach (var kv in template.ExtraTerms)
            {
                TermModel termModel;
                if (!termMap.TryGetValue(kv.Key, out termModel!))
                {
                    throw new ArgumentException($"Standard term name '{kv.Key}' not found in template term names.");
                }

                var ExtraTerms = kv.Value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                    .Select(etn => new TermModel()
                    {
                        TermName = etn,
                        StandardTerm = termModel,
                        StandardTermId = termModel.TermId ?? String.Empty,
                        TermType = TermType.Extra
                    }).ToList();

                termModel.ExtraTerms = ExtraTerms;
            }

            return terms;
        }
    }
}
