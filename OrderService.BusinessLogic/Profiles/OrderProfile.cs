using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using OrderService.BusinessLogic.Models;
using OrderService.Contract.Entities;
using ProductService.BusinessLogic.Models;

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

            CreateMap<GetProductsByIdsReply, Order>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
                .ForMember(dest => dest.Sum, opt => opt.MapFrom(src => src.Products.Sum(x => x.Count * x.Price)));
        }
    }
}