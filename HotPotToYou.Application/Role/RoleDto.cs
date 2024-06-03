using AutoMapper;
using HotPotToYou.Application.Common.Mapping;
using HotPotToYou.Domain.Entity.ConfigTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Role
{
    public class RoleDto : IMapFrom<RoleEntity>
    {
        public RoleDto()
        { 
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public static RoleDto Create(int id, string name)
        {
            return new RoleDto
            {
                ID = id,
                Name = name
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RoleEntity, RoleDto>();
        }
    }
}
