using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class GradesClassification : ICloneable
    {
        public string GradesClassificationId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Value { get; set; }
        public int Depth { get; set; }
        public string? ParentId { get; set; } = null!;
        public GradesClassification Parent { get; set; } = null!;
        public ICollection<GradesClassification> Children { get; set; } = null!;

        public GradesClassification(){}

        public GradesClassification(GradesClassification parent)
        {
            if(parent.Children == null) parent.Children = new List<GradesClassification>();
            Parent = parent;
            parent.Children.Add(this);
        }

        public object Clone()
        {
            var root = new GradesClassification
            {
                Name = Name,
                Value = Value,
                Depth = Depth
            };
            if (Children == null) return root;
            root.Children = new List<GradesClassification>();

            foreach (var child in Children)
            {
                var childClone = (GradesClassification)child.Clone();
                childClone.Parent = root;
                root.Children.Add(childClone);
            }

            return root;
        }

    }
}
