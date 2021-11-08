namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Запрос на удаление заказа
    /// </summary>
    public class DeleteOrderRequest
    {
        /// <summary>
        ///     Идентификатор заказа
        /// </summary>
        public long OrderId { get; set; }
    }
}