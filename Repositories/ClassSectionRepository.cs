using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Y2S1_INC_Compliance_proj.Data;

namespace Finals.Repositories
{
    public class ClassSectionRepository : BaseRepository<ClassSectionModel>, IClassSectionRepository
    {
        public ClassSectionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
