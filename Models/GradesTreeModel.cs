using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class GradesTreeModel
    {
        public string TreeId { get; set; } = null!;
        public string TreeName { get; set; } = null!;
        public string RootId { get; set; } = null!;
        public GradesClassification Root { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public GradesTreeType TreeType { get; set; } = GradesTreeType.Default;
    }

    public enum GradesTreeType
    {
        Default, ExistingTree, TemplateTree
    }
}
