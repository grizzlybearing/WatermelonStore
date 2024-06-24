using API.BusinessLogicLayer.DTO.OrderItems;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.OrderItems
{
    public class OrderItemsDTOValidator : AbstractValidator<OrderItemsDTO>
    {
        public OrderItemsDTOValidator()
        {
            RuleFor(x => x. Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("OrderId is required.")
                .Must(x => x != Guid.Empty).WithMessage("OrderId must be a valid Guid.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("ProductId is required.")
                .Must(x => x != Guid.Empty).WithMessage("ProductId must be a valid Guid.");

            RuleFor(x => x.Quantity)
                .NotEmpty().WithMessage("Quantity is required.")
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.");

            RuleFor(x => x.UnitPrice)
                .NotEmpty().WithMessage("UnitPrice is required.")
                .GreaterThan(0).WithMessage("UnitPrice must be greater than zero.");

            RuleFor(x => x.TotalPrice)
                .NotEmpty().WithMessage("TotalPrice is required.")
                .GreaterThan(0).WithMessage("TotalPrice must be greater than zero.");
        }
    }
}
