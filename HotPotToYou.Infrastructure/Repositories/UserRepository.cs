using AutoMapper;
using HotPotToYou.Domain.Entity;
using HotPotToYou.Domain.Entity.ConfigTable;
using HotPotToYou.Domain.Repositories.ConfigTable;
using HotPotToYou.Domain.Repositories.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<UserEntity, UserEntity, ApplicationDbContext>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        public string GeneratePassword()
        {
            var characters = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%";

            var random = new Random();

            StringBuilder sb = new StringBuilder();
            while (sb.Length < 7)
            {

                // Get a random index
                var index = random.Next(characters.Length);

                // Get character at index
                var character = characters[index];

                // Append to string builder
                sb.Append(character);
            }

            return sb.ToString();
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
