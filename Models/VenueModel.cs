using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class VenueModel
    {
        public string VenueId { get; set; } = null!;
        public string Location { get; set; } = null!;
        public Day Day { get; set; }

        public string AssignedCourseModelId { get; set; } = null!;
        public CourseModel_Assigned AssignedCourseModel { get; set; } = null!;
    }

    public enum Day { Su, M, T, W, Th, F, S,
        NotSet
    } // S = Sunday, M = Monday, T = Tuesday, W = Wednesday, Th = Thursday, F = Friday, Sa = Saturday
}
