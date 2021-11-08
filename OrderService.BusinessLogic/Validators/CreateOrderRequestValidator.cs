using System.Linq;
using FluentValidation;
using OrderService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Validators
{
    public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .WithMessage("Request cannot be null");
            
            RuleFor(x => x.CustomerId)
                .NotNull()
                .WithMessage("Customer id cannot be null")
                .GreaterThan(0)
                .WithMessage(x => $"Invalid field 'ProductId'. Value: {x.CustomerId}");

            RuleFor(x => x.ProductIds)
                .NotEmpty()
                .WithMessage("")
                .Must(x => x.Any())
                .WithMessage("Product ids must contains at least one item");
        }
    }
}