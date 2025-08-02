using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Models
{
    public class ClassEntryModel
    {
        public string EntryId { get; set; } = null!;    
        
        public DateTime EntryDate { get; set; }
        public string ClassSectionId { get; set; } = null!;
        public ClassSectionModel ClassSection { get; set; } = null!;

        public string BatchId { get; set;} = null!;
        public ClassBatchModel ClassBatch { get; set; } = null!;

        public string StudentId { get; set; } = null!;
        public UserModel Student { get; set;} = null!;
    }
}
