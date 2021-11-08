using System.Collections.Generic;
using System.Threading.Tasks;
using OrderService.Contract.Entities;

namespace OrderService.Contract.Interfaces
{
    /// <summary>
    ///     Интерфейс для бизнес-логики сервиса заказов
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        ///     Сформировать новый заказ
        /// </summary>
        /// <param name="order">Сущность заказа</param>
        /// <returns>Данные о добавленном заказе</returns>
        Task<Order> CreateOrderAsync(Order order);

        /// <summary>
        ///     Обновить информацию о заказе
        /// </summary>
        /// <param name="order">Сущность заказа</param>
        /// <returns>Обновленная информация о заказе</returns>
        Task<Order> UpdateOrderAsync(Order order);

        /// <summary>
        ///     Удалить заказ
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        /// <returns>Информация об удаленном заказе</returns>
        Task<Order> DeleteOrderAsync(long orderId);

        /// <summary>
        ///     Получить заказ по идентификатору
        /// </summary>
        /// <param name="orderId">Идентификатор заказа</param>
        /// <returns>Информация о заказе</returns>
        Task<Order> GetOrderByIdAsync(long orderId);
        
        /// <summary>
        ///     Вернуть все заказы
        /// </summary>
        /// <returns>Список заказов</returns>
        Task<IReadOnlyCollection<Order>> GetAllOrdersAsync();

        /// <summary>
        ///     Вернуть все зазазы для конкретного покупателя
        /// </summary>
        /// <param name="customerId">Идентификатор покупателя</param>
        /// <returns>Список заказов покупателя</returns>
        Task<IReadOnlyCollection<Order>> GetOrdersByCustomerIdAsync(long customerId);
    }
}