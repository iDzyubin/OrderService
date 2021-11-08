using System.Collections.Generic;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос о добавлении заказа
    /// </summary>
    public class CreateOrderReply
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }
        
        /// <summary>
        ///     Сумма заказа
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        ///     Позиции товаров в заказе
        /// </summary>
        public List<Product> Products { get; set; }
    }
}