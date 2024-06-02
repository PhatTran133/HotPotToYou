using HotPotToYou.Application.Role.CreateRole;
using HotPotToYou.Domain.Common.Exceptions;
using HotPotToYou.Domain.Entity;
using HotPotToYou.Domain.Entity.ConfigTable;
using HotPotToYou.Domain.Repositories.ConfigTable;
using HotPotToYou.Domain.Repositories.Table;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepositor)
        {
            _userRepository = userRepositor;
        }
        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //NHỚ CHECK NGÀY XÓA
            var checkEmail = await _userRepository.AnyAsync(x => x.Email == request.Email && x.DeleteDate == null, cancellationToken);
            if (checkEmail)
                throw new DuplicationException("Email is existing");
            var checkPhone = await _userRepository.AnyAsync(x => x.Phone == request.Phone && x.DeleteDate == null, cancellationToken);
            if (checkPhone)
                throw new DuplicationException("Phone is existing");


            var user = new UserEntity()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Gender = request.Gender,
                Phone = request.Phone,
                Status = "Active",
                RoleID = 2,
                //CreateByID = _currentUserService.UserId,
                CreateDate = DateTime.Now
            };
            _userRepository.Add(user);
            if (await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0)
                return "Create Successfully";
            else
                return "Create Failed";
        }
    }
}
