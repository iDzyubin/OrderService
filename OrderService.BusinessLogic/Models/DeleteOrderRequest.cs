using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на удаление заказа
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.DeleteOrderRequest)]
    public class DeleteOrderRequest : Request
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long OrderId { get; set; }
    }
}