using FluentValidation;
using API.BusinessLogicLayer.DTO.Product;

namespace API.BusinessLogicLayer.Validators.Product
{
    public class ProductDTOValidator: AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Id)
                    .NotEmpty().WithMessage("Id is required.");
            RuleFor(x => x.Name)
                    .NotEmpty().WithMessage("Name is required.")
                    .MaximumLength(40).WithMessage("Name is too long.")
                    .MinimumLength(6).WithMessage("Name is too short.");
            RuleFor(x => x.Description)
                    .MaximumLength(100).WithMessage("Description is too long.")
                    .MinimumLength(20).WithMessage("Description is too short.");
            RuleFor(x => x.Price)
                    .NotEmpty().WithMessage("Price is required.");
            RuleFor(x => x.CategoryId)
                    .NotEmpty().WithMessage("Category is required.");
        }

    }
}
