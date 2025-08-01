using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class ClassSectionTransitionModel
    {
        public string TransitionId { get; set; } = null!;
        public string FromSectionId { get; set; } = null!;
        public ClassSectionModel FromSection { get; set; } = null!;
        public string ToSectionId { get; set; } = null!;    
        public ClassSectionModel ToSection { get; set; } = null!;
        public double TransitionPercentage { get; set; }
        public bool IsLocked { get; set; } = false;
    }
}
