﻿using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NATS.Client;
using OrderService.BusinessLogic.Contexts;
using OrderService.BusinessLogic.Validators;

namespace OrderService.BusinessLogic.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<OrderContext>(builder => 
                builder.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    x => x.MigrationsAssembly("OrderService.BusinessLogic")));
        }
        
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            return services.AddFluentValidation(configuration =>
            {
                configuration.RegisterValidatorsFromAssemblyContaining<AnchorValidator>();
                configuration.ImplicitlyValidateChildProperties = true;
                configuration.ImplicitlyValidateRootCollectionElements = true;
                configuration.DisableDataAnnotationsValidation = true;
            });
        }
        
        public static IServiceCollection AddAutomapper(this IServiceCollection services)
        {
            return services.AddSingleton(
                new MapperConfiguration(configuration => 
                        configuration.AddMaps("OrderService.BusinessLogic"))
                    .CreateMapper());
        }
        
        public static IServiceCollection AddNats(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddTransient(_ =>
            {
                var factory = new ConnectionFactory();
                var options = ConnectionFactory.GetDefaultOptions();
                options.Url = configuration.GetConnectionString("NatsConnection");
                return factory.CreateConnection();
            });
        }
    }
}