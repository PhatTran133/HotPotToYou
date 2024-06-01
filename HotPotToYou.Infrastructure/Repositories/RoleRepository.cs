using AutoMapper;
using HotPotToYou.Domain.Entity.ConfigTable;
using HotPotToYou.Domain.Repositories.ConfigTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Infrastructure.Repositories
{
    public class RoleRepository : RepositoryBase<RoleEntity, RoleEntity, ApplicationDbContext>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
