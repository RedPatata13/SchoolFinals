using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories;
using Finals.Repositories.Interfaces;
using Y2S1_INC_Compliance_proj.Data;

namespace Finals.Core
{
    public static class RepositoryFactory
    {
        public static IRepository Create()
        {
            return new Repository(new AppDbContextFactory().CreateDbContext());
        }
    }
}
