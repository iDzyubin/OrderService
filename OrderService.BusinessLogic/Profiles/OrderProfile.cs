using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using OrderService.BusinessLogic.Models;
using OrderService.Contract.Entities;

namespace OrderService.BusinessLogic.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, CreateOrderReply>();
            
            CreateMap<UpdateOrderRequest, Order>();
            CreateMap<Order, UpdateOrderReply>();
            
            CreateMap<Order, DeleteOrderReply>();
            CreateMap<Order, GetOrderByIdReply>();

            CreateMap<IEnumerable<Order>, GetOrdersReply>()
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src));
            CreateMap<IEnumerable<Order>, GetOrdersByCustomerIdReply>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.First().CustomerId))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src));
        }
    }
}