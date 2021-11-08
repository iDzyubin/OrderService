using System.Collections.Generic;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на обновление информации по заказу
    /// </summary>
    public class UpdateOrderRequest
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