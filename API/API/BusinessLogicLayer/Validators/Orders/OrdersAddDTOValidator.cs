using API.BusinessLogicLayer.DTO.Orders;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.Orders
{
    public class OrdersAddDTOValidator : AbstractValidator<OrdersAddDTO>
    {
        public OrdersAddDTOValidator()
        {
            RuleFor(x => x.OrderDate)
                .NotEmpty().WithMessage("OrderDate is required.");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required.")
                .Must(x => x != Guid.Empty).WithMessage("UserId must be a valid Guid.");

            RuleFor(x => x.TotalAmount)
                .NotEmpty().WithMessage("TotalAmount is required.")
                .GreaterThan(0).WithMessage("TotalAmount must be greater than zero.");
        }
    }
}
