using System.Collections.Generic;

namespace OrderService.Contract.Entities
{
    /// <summary>
    ///     Сущность заказа
    /// </summary>
    public class Order : Entity
    {
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