using FluentValidation;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Validators
{
    /// <summary>
    ///     Пустой валидатор за который будем биндить все остальные
    /// </summary>
    public class AnchorValidator : AbstractValidator<Order>
    {
    }
}