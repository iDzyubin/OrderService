using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Entities;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос о получении товаров по идентификаторам
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetProductsByIdsReply)]
    public class GetProductsByIdsReply : Reply
    {
        /// <summary>
        ///     Искомые товары
        /// </summary>
        public IEnumerable<Product> Products { get; set; }
    }
}