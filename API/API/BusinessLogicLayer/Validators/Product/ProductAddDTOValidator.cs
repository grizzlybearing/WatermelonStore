using FluentValidation;
using API.BusinessLogicLayer.DTO.Product;

namespace API.BusinessLogicLayer.Validators.Product
{
    public class ProductAddDTOValidator : AbstractValidator<ProductAddDTO>
    {
        public ProductAddDTOValidator()
        {
            RuleFor(x => x.Name)
                    .NotEmpty().WithMessage("Name is required.")
                    .MaximumLength(40).WithMessage("Name is too long.")
                    .MinimumLength(6).WithMessage("Name is too short.");
            RuleFor(x => x.Description)
                    .MaximumLength(100).WithMessage("Name is too long.")
                    .MinimumLength(20).WithMessage("Name is too short.");
            RuleFor(x => x.Price)
                    .NotEmpty().WithMessage("Price is required.");
            RuleFor(x => x.CategoryId)
                    .NotEmpty().WithMessage("Category is required.");
        }

    }
}
