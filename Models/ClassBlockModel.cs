using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Models
{
    public class ClassBlockModel
    {
        string BlockId { get; set; } = null!;
        string BlockName { get; set; } = null!; 
        ICollection<UserModel> Students { get; set; } = null!;
        
        string ClassSectionId { get; set;} = null!;
        ClassSectionModel ClassSection { get; set; } = null!;
    }
}
