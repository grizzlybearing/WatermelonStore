using FluentValidation;
using API.BusinessLogicLayer.DTO.Category;

namespace API.BusinessLogicLayer.Validators.Category
{
    public class CategoryAddDTOValidator : AbstractValidator<CategoryAddDTO>
    {
        public CategoryAddDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(40).WithMessage("Name is too long.")
                .MinimumLength(6).WithMessage("Name is too short.");

        }

    }
}
