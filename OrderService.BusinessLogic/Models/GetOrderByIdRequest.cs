using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение заказа
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrderByIdRequest)]
    public class GetOrderByIdRequest : Request
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long OrderId { get; set; }
    }
}