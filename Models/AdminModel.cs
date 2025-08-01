using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2S1_INC_Compliance_proj.Models
{
    public class AdminModel
    {
        public string AdminID { get; set; } = null!;

        public string UserID { get; set; } = null!;
        public UserModel User { get; set; } = null!;
    }
}
