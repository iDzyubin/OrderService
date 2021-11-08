using System.Collections.Generic;
using NatsExtensions.Models;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос заказов для указанного покупателя
    /// </summary>
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