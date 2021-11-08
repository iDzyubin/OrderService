using ProductService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Adapters
{
    /// <summary>
    /// Адаптер для общения с сервисом товаров
    /// </summary>
    public interface IProductServiceAdapter
    {
        /// <summary>
        ///     Получить товары по идентификаторам
        /// </summary>
        /// <param name="request">Тело запроса</param>
        /// <returns>Ответ на запрос</returns>
        GetProductsByIdsReply GetProductsByIds(GetProductsByIdsRequest request);
    }
}