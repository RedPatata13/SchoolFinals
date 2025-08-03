using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Data;
using Finals.Models;
using Finals.Repositories.Interfaces;

namespace Finals.Repositories
{
    public class GradesTreeRepository : BaseRepository<GradesTreeModel>, IGradesTreeRepository
    {
        public GradesTreeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
