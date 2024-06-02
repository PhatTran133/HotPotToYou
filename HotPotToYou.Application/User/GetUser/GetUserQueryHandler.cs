using AutoMapper;
using HotPotToYou.Domain.Common.Exceptions;
using HotPotToYou.Domain.Repositories.Table;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {

            var user = await _userRepository.FindAsync(x => x.Email == request.Email && x.Password == request.Password && x.DeleteDate == null, cancellationToken);
            if (user == null)
                throw new NotFoundException("Wrong email or password");

            return user.MapToUserDto(_mapper);

        }
    }
}
