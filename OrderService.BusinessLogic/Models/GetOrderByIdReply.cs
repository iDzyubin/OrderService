﻿using System.Collections.Generic;
using NatsExtensions.Attributes;
using NatsExtensions.Models;
using OrderService.Contract.Entities;
using OrderService.Contract.Messages;

namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Ответ на запрос о получении заказа
    /// </summary>
    [ServiceBus(Code = ServiceBusCodes.GetOrderByIdReply)]
    public class GetOrderByIdReply : Reply
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