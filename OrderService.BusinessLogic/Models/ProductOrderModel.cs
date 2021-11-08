namespace OrderService.BusinessLogic.Models
{
    /// <summary>
    ///     Модель для хранения данных о товаре
    /// </summary>
    public class ProductOrderModel
    {
        /// <summary>
        ///     Идентификатор товара
        /// </summary>
        public long ProductId { get; set; }
        
        /// <summary>
        ///     Количество товара в заказе
        /// </summary>
        public int Count { get; set; }
    }
}