namespace OrderService.Contract.Messages
{
    /// <summary>
    ///     Коды взаимодействия с шиной данных
    /// </summary>
    public class ServiceBusCodes
    {
        #region Order Service Codes

        public const int GetOrdersRequest = 20001;

        public const int GetOrdersReply = 20002;

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
        public const int UpdateProductRequest = 30004;
        
        /// <summary>
        ///     Ответ на запрос обновления информации о товаре
        /// </summary>
        public const int UpdateProductReply = 30004;
        
        #endregion
    }
}