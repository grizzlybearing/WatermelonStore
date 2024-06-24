using API.BusinessLogicLayer.DTO.User;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.User
{
    public class UserDTOValidator : AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(x => x.id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.password)
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}
