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
                .WithMessage(x => $"Invalid field 'CustomerId'. Value: {x.CustomerId}");

            RuleFor(x => x.Products)
                .NotEmpty()
                .WithMessage("Product's list cannot be empty")
                .Must(x => x.Any())
                .WithMessage("Product's list must contains at least one item");
        }
    }
}