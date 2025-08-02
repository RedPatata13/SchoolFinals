using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class ProgramModel
    {
        public string ProgramId { get; set; } = null!;
        public string ProgramName { get; set; } = null!;
        public string ProgramDescription { get; set; } = null!;
        public bool IsOpen { get; set; }

        public string LastEditorId { get; set;} = null!;
        public UserModel LastEditedBy { get; set; } = null!;
        public string CreatorId { get; set; } = null!;
        public UserModel CreatedBy { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public ICollection<ClassSectionModel> ClassSections { get; set; } = null!;
        public ICollection<CourseTemplateModel> courseTemplates { get; set; } = null!;
    }
}
