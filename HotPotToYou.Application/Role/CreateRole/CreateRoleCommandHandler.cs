using HotPotToYou.Domain.Common.Exceptions;
using HotPotToYou.Domain.Entity.ConfigTable;
using HotPotToYou.Domain.Repositories.ConfigTable;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Role.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, string>
    {
        private readonly IRoleRepository _roleRepository;
        public CreateRoleCommandHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<string> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            //NHỚ CHECK NGÀY XÓA
            var checkDuplication = await _roleRepository.AnyAsync(x => x.Name == request.Name && x.DeleteDate == null, cancellationToken);
            if (checkDuplication)
                throw new DuplicationException("Role is existing");

            var role = new RoleEntity()
            {
                Name = request.Name,
                //CreateByID = _currentUserService.UserId,
                CreateDate = DateTime.Now
            };
            _roleRepository.Add(role);
            if (await _roleRepository.UnitOfWork.SaveChangesAsync(cancellationToken) > 0)
                return "Create Successfully";
            else
                return "Create Failed";
        }
    }
}
