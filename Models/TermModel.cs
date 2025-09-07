using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{ 
    public class TermModel
    {
        public string TermId { get; set; } = null!;
        public string TermName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool IsActive { get; set; } = false;
        public TermStatus Status { get; set; } = TermStatus.Preparatory;
        public TermType TermType = TermType.Standard;

        // has to be of type: SemesterType.Extra
        public ICollection<TermModel>? ExtraTerms { get; set; } = null!;
        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel SchoolYear { get; set; } = null!;

        //public bool IsExtraTerm = false;
        public string? StandardTermId = null!;
        public TermModel? StandardTerm = null!;

        public int Precendence { get; set; } = -1;
    }

    public enum TermStatus
    {
        Ongoing,
        Concluded,
        Preparatory
    }

    public enum TermType
    {
        Standard, Extra, TemplateItem
    }
}
