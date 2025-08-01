using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Models
{
    public class SemesterModel
    {
        public string SemesterId { get; set; } = null!;
        public string SemesterName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }


        public string SchoolYearId { get; set; } = null!;
        public SchoolYearModel SchoolYear { get; set; } = null!;
    }
}
