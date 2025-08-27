using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class SemesterModel
    {
        public string SemesterId { get; set; } = null!;
        public string SemesterName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool IsActive { get; set; } = true;
        public SemesterStatus Status { get; set; } = SemesterStatus.Preparatory;
        public SemesterType SemesterType = SemesterType.Standard;

        // has to be of type: SemesterType.Extra
        public ICollection<SemesterModel>? ExtraSemesters { get; set; } = null!;
        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel SchoolYear { get; set; } = null!;

        public string? StandardSemesterId = null!;
        public SemesterModel? StandardSemester = null!;
    }

    public enum SemesterStatus
    {
        Ongoing,
        Concluded,
        Preparatory
    }

    public enum SemesterType
    {
        Standard, Extra, TemplateItem
    }
}
