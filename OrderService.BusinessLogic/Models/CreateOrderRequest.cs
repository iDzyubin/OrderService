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
        ///     Товары в заказе и их количество
        /// </summary>
        public List<ProductOrderModel> Products { get; set; }
    }
}