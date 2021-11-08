using FluentValidation;
using OrderService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Validators
{
    public class GetOrdersByCustomerIdRequestValidator : AbstractValidator<GetOrdersByCustomerIdRequest>
    {
        public GetOrdersByCustomerIdRequestValidator()
        {
            
        }
    }
}