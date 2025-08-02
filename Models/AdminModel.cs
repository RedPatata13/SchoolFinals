using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class AdminModel
    {
        public string AdminID { get; set; } = null!;

        public string UserID { get; set; } = null!;
        public UserModel User { get; set; } = null!;
    }
}
