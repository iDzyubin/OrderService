using FluentValidation;
using OrderService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Validators
{
    public class GetOrdersByCustomerIdRequestValidator : AbstractValidator<GetOrdersByCustomerIdRequest>
    {
        public GetOrdersByCustomerIdRequestValidator()
        {
            RuleFor(x => x.CustomerId)
                .GreaterThan(0)
                .WithMessage("Некоректный идентификатор покупателя");
        }
    }
}