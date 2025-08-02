using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class CourseTemplateModel
    {
        public string TemplateId { get; set; } = null!;
        public string TemplateName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string CreatorId { get; set; } = null!;
        public UserModel Creator { get; set; } = null!;
        public string ProgramId { get; set; } = null!;
        public ProgramModel Program { get; set; } = null!;
        public ICollection<CourseTemplateItem> Items { get; set; } = new List<CourseTemplateItem>();
    }
}
