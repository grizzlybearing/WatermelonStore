using API.BusinessLogicLayer.DTO.User;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.User
{
    public class UserUpdateDTOValidator : AbstractValidator<UserUpdateDTO>
    {
        public UserUpdateDTOValidator()
        {
            RuleFor(x => x.id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.email)
                .EmailAddress().WithMessage("Invalid email format.")
                .When(x => !string.IsNullOrEmpty(x.email));

            RuleFor(x => x.password)
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .When(x => !string.IsNullOrEmpty(x.password));
        }
    }
}
