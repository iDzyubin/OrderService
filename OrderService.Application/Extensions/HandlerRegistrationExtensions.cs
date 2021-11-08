using Microsoft.Extensions.DependencyInjection;
using NatsExtensions.Handlers;
using NatsExtensions.HostedServices;
using OrderService.Application.Handlers;
using OrderService.BusinessLogic.Models;

namespace OrderService.Application.Extensions
{
    public static class HandlerRegistrationExtensions
    {
        public static IServiceCollection AddHandlersToHost(this IServiceCollection services)
        {
            services.AddHandlers();
            
            services.AddHostedService<RegisterHandlerService<GetOrdersByCustomerIdRequest, GetOrdersByCustomerIdReply>>();
            
            return services;
        }
        
        private static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<IHandler<GetOrdersByCustomerIdRequest, GetOrdersByCustomerIdReply>, GetOrdersByCustomerIdHandler>();
            return services;
        }
    }
}