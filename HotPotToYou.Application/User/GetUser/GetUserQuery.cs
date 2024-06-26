﻿using HotPotToYou.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.GetUser
{
    public class GetUserQuery : IRequest<UserDto>, ICommand
    {
        public GetUserQuery(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public string Email { get; set; }
        public string Password { get; set; }
    }
}
