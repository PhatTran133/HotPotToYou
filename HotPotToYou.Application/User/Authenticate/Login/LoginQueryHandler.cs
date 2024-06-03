using AutoMapper;
using HotPotToYou.Domain.Common.Exceptions;
using HotPotToYou.Domain.Repositories.ConfigTable;
using HotPotToYou.Domain.Repositories.Table;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.Authenticate.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, UserDtoLogin>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IRoleRepository _roleRepository;

        public LoginQueryHandler(IUserRepository userRepository, IMapper mapper, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<UserDtoLogin> Handle(LoginQuery request, CancellationToken cancellationToken)
        {

            var user = await _userRepository.FindAsync(x => x.Email == request.user.Email && x.DeleteDate == null);
            if (user == null)
            {
                throw new NotFoundException($"Email is not found - {request.user.Email}");
            }

            if (user != null)
            {
                var chucvu = await _roleRepository.FindAsync(x => x.ID == user.RoleID && x.DeleteDate == null);
                if (chucvu == null)
                {
                    throw new NotFoundException($"Role is not found - {request.user.Email}");
                }

                var samePassword = _userRepository.VerifyPassword(request.user.Password, user.Password);
                if (samePassword)
                {
                    return UserDtoLogin.Create(user.Email, user.ID, chucvu.Name);
                }
            }

            throw new NotFoundException("Wrong Email Or Password");
        }
    }
}
