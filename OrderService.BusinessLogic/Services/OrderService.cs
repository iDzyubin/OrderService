using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderService.BusinessLogic.Contexts;
using OrderService.Contract.Entities;
using OrderService.Contract.Interfaces;

namespace OrderService.BusinessLogic.Services
{
    /// <summary>
    ///     Бизнес-логика сервиса заказов
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly OrderContext _orderContext;

        public OrderService(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            try
            {
                // TODO. Service bus transfer here.
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Cannot create an order");
            }
            
            var result = await _orderContext.Orders.AddAsync(order);
            await _orderContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            if (await _orderContext.Orders.AnyAsync(x => x.Id == order.Id))
                throw new InvalidOperationException("Order was not found");

            try
            {
                // TODO. Service bus transfer here.
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Cannot update an order");
            }
            
            var result = _orderContext.Update(order);
            await _orderContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Order> DeleteOrderAsync(long orderId)
        {
            var order = await _orderContext.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
            if (order == null)
                throw new InvalidOperationException("Order was not found");

            var result = _orderContext.Remove(order);
            await _orderContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Order> GetOrderByIdAsync(long orderId) =>
            await _orderContext.Orders
                .Where(x => x.Id == orderId)
                .Include(x => x.Products)
                .FirstOrDefaultAsync();

        public async Task<IReadOnlyCollection<Order>> GetAllOrdersAsync() =>
            await _orderContext.Orders
                .Include(x => x.Products)
                .ToListAsync();

        public async Task<IReadOnlyCollection<Order>> GetOrdersByCustomerIdAsync(long customerId) =>
            await _orderContext.Orders
                .Where(x => x.CustomerId == customerId)
                .Include(x => x.Products)
                .ToListAsync();
    }
}