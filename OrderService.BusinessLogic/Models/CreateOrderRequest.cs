using System.Collections.Generic;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на создание заказа
    /// </summary>
    public class CreateOrderRequest
    {
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        ///     Идентификаторы товаров в заказе
        /// </summary>
        public List<long> ProductIds { get; set; }
    }
}