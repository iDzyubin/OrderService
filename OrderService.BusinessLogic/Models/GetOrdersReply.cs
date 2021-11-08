using System.Collections.Generic;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос о получении всех заказов
    /// </summary>
    public class GetOrdersReply
    {
        /// <summary>
        ///     Коллекция заказов
        /// </summary>
        public IReadOnlyCollection<Order> Orders { get; set; }
    }
}