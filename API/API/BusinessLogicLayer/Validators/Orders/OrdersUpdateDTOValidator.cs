using API.BusinessLogicLayer.DTO.Orders;
using FluentValidation;

namespace API.BusinessLogicLayer.Validators.Orders
{
    public class OrdersUpdateDTOValidator : AbstractValidator<OrdersUpdateDTO>
    {
        public OrdersUpdateDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(x => x.OrderDate)
                .NotEmpty().WithMessage("OrderDate is required.");

            RuleFor(x => x.UserId)
                .Must(x => x != Guid.Empty).WithMessage("UserId must be a valid Guid.")
                .When(x => x.UserId != Guid.Empty);

            RuleFor(x => x.TotalAmount)
                .GreaterThan(0).WithMessage("TotalAmount must be greater than zero.")
                .When(x => x.TotalAmount != 0);
        }
    }
}
