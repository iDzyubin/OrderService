namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на получение заказа
    /// </summary>
    public class GetOrderByIdRequest
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long OrderId { get; set; }
    }
}