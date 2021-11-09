using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на обновление информации по заказу
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.UpdateOrderRequest)]
    public class UpdateOrderRequest : Request
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long OrderId { get; set; }
        
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        ///     Товары в заказе и их количество
        /// </summary>
        public List<ProductOrderModel> Products { get; set; }
    }
}