using Microsoft.EntityFrameworkCore;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Contexts
{
    /// <summary>
    ///     Контекст данных для сервиса заказов
    /// </summary>
    public class OrderContext : DbContext
    {
        /// <summary>
        ///     Заказы
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        
        /// <summary>
        ///     Товары в заказах
        /// </summary>
        public DbSet<Product> Products { get; set; }

        public OrderContext(DbContextOptions options) : base(options)
        {
        }
    }
}