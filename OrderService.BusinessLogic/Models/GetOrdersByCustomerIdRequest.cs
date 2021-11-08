using NatsExtensions.Models;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение товаров указанного покупателя
    /// </summary>
    public class GetOrdersByCustomerIdRequest : Request
    {
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }
    }
}