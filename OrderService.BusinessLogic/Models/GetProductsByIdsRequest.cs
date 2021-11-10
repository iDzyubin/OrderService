using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение товаров по идентификаторам
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetProductsByIdsRequest)]
    public class GetProductsByIdsRequest : Request
    {
        /// <summary>
        /// Идентификаторы искомых товаров
        /// </summary>
        public IEnumerable<long> ProductIds { get; set; }
    }
}