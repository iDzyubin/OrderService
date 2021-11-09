using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на создание заказа
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.CreateOrderRequest)]
    public class CreateOrderRequest : Request
    {
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