using HotPotToYou.Application.Common.Interfaces;
using HotPotToYou.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.Authenticate.Login
{
    public class LoginQuery : IRequest<UserDtoLogin>, IQuery
    {
        public LoginQuery()
        {

        }


        public LoginQuery(LoginEntity loginEntity)
        {
            user.Email = loginEntity.Email;
            user.Password = loginEntity.Password;
        }
        [Required] public LoginEntity user { get; set; }


    }
}
