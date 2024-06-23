using FluentValidation;
using API.BusinessLogicLayer.DTO.Category;

namespace API.BusinessLogicLayer.Validators.Category
{
    public class CategoryDTOValidator : AbstractValidator<CategoryDTO>
    {
        public  CategoryDTOValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(40).WithMessage("Name is too long.")
                .MinimumLength(6).WithMessage("Name is too short.");

        }

    }
}
