using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class ClassSectionEditLog
    {
        public string LogId { get; set; } = null!;
        public string SectionId { get; set; } = null!;
        public ClassSectionModel Section { get; set; } = null!;
        public string EditedByUserId { get; set; } = null!;
        public UserModel EditedByUser { get; set; } = null!;
        public DateTime EditDateTime { get; set; }
        public string EditDescription { get; set; } = null!;
        public ClassSectionEditType EditType { get; set; }
        public ClassSectionEditLog()
        {
            //EditDateTime = DateTime.Now;
        }
    }

    public enum ClassSectionEditType
    {
        SectionCreated,
        SectionNameChange,
        SectionTransitionChange,
        SectionStudentsChange,
        SectionProgramChange,
    }
}
