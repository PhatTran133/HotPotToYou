using AutoMapper;
using HotPotToYou.Domain.Entity.ConfigTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Role
{
    public static class RoleDtoMappingExtensions
    {
        public static RoleDto MapToRoleDto(this RoleEntity projectFrom, IMapper mapper)
            => mapper.Map<RoleDto>(projectFrom);

        public static List<RoleDto> MapToRoleDtoList(this IEnumerable<RoleEntity> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToRoleDto(mapper)).ToList();
    }
}
