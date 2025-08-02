using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Finals.Repositories.Interfaces;
using Finals.Data;

namespace Finals.Repositories
{
    public class ClassEntryRepository : BaseRepository<ClassEntryModel>, IClassEntryRepository
    {
        public ClassEntryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
