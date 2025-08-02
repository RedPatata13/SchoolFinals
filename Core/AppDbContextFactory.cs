using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finals.Data;

namespace Finals.Core
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>, IDisposable
    {   
        public AppDbContext CreateDbContext()
        {
            return new AppDbContext();
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
