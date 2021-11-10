namespace OrderService.Contract.Messages
{
    /// <summary>
    ///     Коды взаимодействия с шиной данных
    /// </summary>
    public class ServiceBusCodes
    {
        #region Order Service Codes

        /// <summary>
        ///     Запрос на создание заказа
        /// </summary>
        public const int CreateOrderRequest = 20001;

        /// <summary>
        ///     Ответ на запрос о добавлении заказа
        /// </summary>
        public const int CreateOrderReply = 20002;
        
        /// <summary>
        ///     Запрос на удаление заказа
        /// </summary>
        public const int DeleteOrderRequest = 20003;

        /// <summary>
        ///     Ответ на удалении заказа
        /// </summary>
        public const int DeleteOrderReply = 20004;
        
        /// <summary>
        ///     Запрос на получение заказа
        /// </summary>
        public const int GetOrderByIdRequest = 20005;

        /// <summary>
        ///     Ответ на запрос о получении заказа
        /// </summary>
        public const int GetOrderByIdReply = 20006;
        
        /// <summary>
        ///     Запрос на получение товаров указанного покупателя
        /// </summary>
        public const int GetOrdersByCustomerIdRequest = 20007;

        /// <summary>
        ///     Ответ на запрос заказов для указанного покупателя
        /// </summary>
        public const int GetOrdersByCustomerIdReply = 20008;
        
        /// <summary>
        ///     Запрос на получение товаров указанного покупателя
        /// </summary>
        public const int GetOrdersRequest = 20009;

        /// <summary>
        ///     Ответ на запрос о получении всех заказов
        /// </summary>
        public const int GetOrdersReply = 20010;
        
        /// <summary>
        ///     Запрос на обновление информации по заказу
        /// </summary>
        public const int UpdateOrderRequest = 20011;

        /// <summary>
        ///     Ответ на запрос об обновлении информации по заказу
        /// </summary>
        public const int UpdateOrderReply = 20012;
        
        #endregion
        
        
        #region Product Service Codes

        /// <summary>
        ///     Запрос на добавление товара
        /// </summary>
        public const int CreateProductRequest = 30001;
        
        /// <summary>
        ///     Ответ на запрос добавления товара
        /// </summary>
        public const int CreateProductReply = 30002;
        
        /// <summary>
        ///     Запрос на удаление товара
        /// </summary>
        public const int DeleteProductRequest = 30003;
        
        /// <summary>
        ///     Ответ на запрос об удалении товара
        /// </summary>
        public const int DeleteProductReply = 30004;
        
        /// <summary>
        ///     Запрос на получение товара
        /// </summary>
        public const int GetProductByIdRequest = 30005;
        
        /// <summary>
        ///     Ответ на запрос на получение товара
        /// </summary>
        public const int GetProductByIdReply = 30006;
        
        /// <summary>
        ///     Запрос на получение товаров по идентификаторам
        /// </summary>
        public const int GetProductsByIdsRequest = 30007;
        
        /// <summary>
        ///     Ответ на запрос о получении товаров по идентификаторам
        /// </summary>
        public const int GetProductsByIdsReply = 30008;
        
        /// <summary>
        ///     Запрос на получение товаров
        /// </summary>
        public const int GetProductsRequest = 30009;
        
        /// <summary>
        ///     Ответ на запрос товаров
        /// </summary>
        public const int GetProductsReply = 30010;
        
        /// <summary>
        ///     Запрос на обновление информации о товаре
        /// </summary>
        public const int UpdateProductRequest = 30011;
        
        /// <summary>
        ///     Ответ на запрос обновления информации о товаре
        /// </summary>
        public const int UpdateProductReply = 30012;
        
        #endregion
    }
}