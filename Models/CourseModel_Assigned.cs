using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Models
{
    public class CourseModel_Assigned
    {
        public string AssignedCourseModelID { get; set; } = null!;
       
        public string CourseId { get; set; } = null!;
        public CourseModel Course { get; set; } = null!;
        

        public string TeacherId { get; set; } = null!;
        public UserModel Teacher { get; set; } = null!;

        public string AssignedId { get; set; } = null!;
        public UserModel AssignedBy { get; set; } = null!;

        public DateTime DateAssigned { get; set; }


    }
}
