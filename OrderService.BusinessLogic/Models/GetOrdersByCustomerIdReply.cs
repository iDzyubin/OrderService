using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Entities;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос заказов для указанного покупателя
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrdersByCustomerIdReply)]
    public class GetOrdersByCustomerIdReply : Reply
    {   
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }
        
        /// <summary>
        ///     Набор товаров указанного пользователя
        /// </summary>
        public IReadOnlyCollection<Order> Orders { get; set; }
    }
}