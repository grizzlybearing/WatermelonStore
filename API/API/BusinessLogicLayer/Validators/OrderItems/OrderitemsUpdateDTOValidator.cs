using API.BusinessLogicLayer.DTO.OrderItems;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.OrderItems
{
    public class OrderItemsUpdateDTOValidator : AbstractValidator<OrderItemsUpdateDTO>
    {
        public OrderItemsUpdateDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.OrderId)
                .Must(x => x != Guid.Empty).WithMessage("OrderId must be a valid Guid.")
                .When(x => x.OrderId != Guid.Empty);

            RuleFor(x => x.ProductId)
                .Must(x => x != Guid.Empty).WithMessage("ProductId must be a valid Guid.")
                .When(x => x.ProductId != Guid.Empty);

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                .When(x => x.Quantity != 0);

            RuleFor(x => x.UnitPrice)
                .GreaterThan(0).WithMessage("UnitPrice must be greater than zero.")
                .When(x => x.UnitPrice != 0);

            RuleFor(x => x.TotalPrice)
                .GreaterThan(0).WithMessage("TotalPrice must be greater than zero.")
                .When(x => x.TotalPrice != 0);
        }
    }
}
