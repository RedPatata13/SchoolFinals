using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Finals.Data;
using Finals.Models;

namespace Finals.Repositories
{
    public class UserModelRepository : BaseRepository<UserModel>, IUserModelRepository
    {
        public UserModelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
