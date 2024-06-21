using API.BusinessLogicLayer.DTO.User;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.User
{
    public class UserAddDTOValidator : AbstractValidator<UserAddDTO>
    {
        public UserAddDTOValidator()
        {
            RuleFor(x => x.email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.");
        }
    }
}
