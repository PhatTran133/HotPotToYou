using AutoMapper;
using HotPotToYou.Application.Role;
using HotPotToYou.Domain.Entity;
using HotPotToYou.Domain.Entity.ConfigTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User
{
    public static class UserDtoMappingExtensions
    {
        public static UserDto MapToUserDto(this UserEntity projectFrom, IMapper mapper)
            => mapper.Map<UserDto>(projectFrom);

        public static List<UserDto> MapTouserDtoList(this IEnumerable<UserEntity> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToUserDto(mapper)).ToList();
    }
}
