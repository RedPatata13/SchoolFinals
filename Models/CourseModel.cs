using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Models
{
    public class CourseModel
    {
        public string CourseId { get; set; } = null!;
        public string CourseName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string Description { get; set; } = null!;
        public string CreatorId { get; set; } = null!;
        public UserModel Creator { get; set;} = null!;

    }
}
