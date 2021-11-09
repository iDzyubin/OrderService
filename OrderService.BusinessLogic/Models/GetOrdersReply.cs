using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Entities;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос о получении всех заказов
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrdersReply)]
    public class GetOrdersReply : Reply
    {
        /// <summary>
        ///     Коллекция заказов
        /// </summary>
        public IReadOnlyCollection<Order> Orders { get; set; }
    }
}