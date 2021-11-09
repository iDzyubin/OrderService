using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение товаров указанного покупателя
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrdersByCustomerIdRequest)]
    public class GetOrdersByCustomerIdRequest : Request
    {
        /// <summary>
        ///     Идентификатор покупателя
        /// </summary>
        public long CustomerId { get; set; }
    }
}