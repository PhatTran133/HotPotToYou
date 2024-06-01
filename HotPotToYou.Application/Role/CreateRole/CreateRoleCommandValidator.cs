using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Application.Role.CreateRole
{
    public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage("Name is required")
               .MaximumLength(10).WithMessage("Name must not exceed 10 characters")
               .Must(StartWithUpperCase).WithMessage("Name must start with an uppercase letter")
               .Matches("^[A-Z][a-zA-Z]*$").WithMessage("Name can only contain letters and must start with an uppercase letter");
        }
        private bool StartWithUpperCase(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            return char.IsUpper(name[0]);
        }
    }
}
