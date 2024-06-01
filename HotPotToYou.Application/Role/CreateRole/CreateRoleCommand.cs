using MediatR;
using HotPotToYou.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Role.CreateRole
{
    public class CreateRoleCommand : IRequest<string>, ICommand
    {
        public CreateRoleCommand(string name)
        {
            Name = name;
        }


        public string Name { get; set; }
    }
}
