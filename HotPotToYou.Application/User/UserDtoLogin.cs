﻿using AutoMapper;
using HotPotToYou.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User
{
    public class UserDtoLogin
    {

        public string Email { get; set; }
        public int ID { get; set; }
        public string Role { get; set; }

        public static UserDtoLogin Create(string email, int id, string role)
        {
            return new UserDtoLogin
            {
                Email = email,
                ID = id,
                Role = role
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserEntity, UserDtoLogin>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name));
        }
    }
}
