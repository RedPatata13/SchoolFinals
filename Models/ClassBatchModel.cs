using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class ClassBatchModel
    {
        public string BatchId { get; set; } = null!;
        public string BatchName { get; set; } = null!;
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; } 

        public string ClassSectionId { get; set; } = null!;
        public ClassSectionModel ClassSection { get; set; } = null!;

        public ICollection<ClassEntryModel> ClassEntries { get; set; } = null!;

        public ClassBatchStatus ClassBatchStatus { get; set; } = ClassBatchStatus.Default;
    }

    public enum ClassBatchStatus
    {
        Default,
        Active,
        Inactive,
    }
}
