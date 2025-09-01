using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Services.SY_Services
{
    public class SYTemplate
    {
        public string TemplateId { get; set; } = null!;
        public string TemplateName { get; set; } = null!;
        /// <summary>
        /// Standard term names. E.g., "1st Semester", "2nd Semester", ... Must be unique.
        /// </summary>
        public List<string> TermNames { get; set; } = new List<string>();

        /// <summary>
        /// Extra terms to be added to each standard term.
        /// key: Standard term name
        /// value: Comma-separated extra term names
        /// </summary>
        public Dictionary<string, string> ExtraTerms { get; set; } = new Dictionary<string, string>();
        public bool IsActive { get; set; } = false;
    }
}
