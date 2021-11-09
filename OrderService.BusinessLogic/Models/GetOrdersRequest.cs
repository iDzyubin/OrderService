using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение всех заказов
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrdersRequest)]
    public class GetOrdersRequest : Request
    {
    }
}