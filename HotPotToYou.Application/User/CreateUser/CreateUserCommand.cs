using MediatR;
using HotPotToYou.Application.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.CreateUser
{
    public class CreateUserCommand : IRequest<string>, ICommand
    {
        public CreateUserCommand(string name, string email, string password, string gender, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Gender = gender;
            Phone = phone;
            Gender = gender;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

    }
}
