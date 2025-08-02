using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

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
