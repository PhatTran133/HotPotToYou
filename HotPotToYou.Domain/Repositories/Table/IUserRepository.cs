using HotPotToYou.Domain.Entity;
using HotPotToYou.Domain.Entity.ConfigTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Domain.Repositories.Table
{
    public interface IUserRepository : IEFRepository<UserEntity, UserEntity>
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
        string GeneratePassword();
    }
}
