using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Repositories.Interfaces;
using Y2S1_INC_Compliance_proj.Data;
using Y2S1_INC_Compliance_proj.Models;

namespace Finals.Repositories
{
    public class UserModelRepository : BaseRepository<UserModel>, IUserModelRepository
    {
        public UserModelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
