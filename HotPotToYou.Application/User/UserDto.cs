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
    public class UserDto
    {
        public UserDto()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }

        public static UserDto Create(int id, string name, string email, string password, string gender, string phone, string status, string role)
        {
            return new UserDto
            {
                ID = id,
                Name = name,
                Email = email,
                Password = password,
                Gender = gender,
                Phone = phone,
                Status = status,
                Role = role
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserEntity, UserDto>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name));
        }
    }
}
