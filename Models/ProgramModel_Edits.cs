using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Models
{
    public class ProgramModel_Edits
    {
        public string Edit_ID { get; set; } = null!;
        public string Edit { get; set;} = null!;
        public string EditorId { get; set; } = null!;
        public UserModel EditedBy { get; set; } = null!;

        public string ProgramId { get; set; } = null!;
        public ProgramModel ProgramEdited { get; set; } = null!;

        public DateTime? EditedAt { get; set; }
    }
}
