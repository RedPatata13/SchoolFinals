using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;

namespace Finals.Repositories.Interfaces
{
    public interface IAssignedCoursesRepository : IBaseRepository<CourseModel_Assigned>
    {
        ICollection<CourseModel_Assigned> GetByClassSectionId(string classSectionId);
    }
}
