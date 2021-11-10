using System;
using System.Threading.Tasks;
using AutoMapper;
using NatsExtensions.Handlers;
using OrderService.BusinessLogic.Models;
using OrderService.BusinessLogic.Validators;
using OrderService.Contract.Interfaces;

namespace OrderService.BusinessLogic.Handlers
{
    public class GetOrdersByCustomerIdHandler : IHandler<GetOrdersByCustomerIdRequest, GetOrdersByCustomerIdReply>
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public GetOrdersByCustomerIdHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<GetOrdersByCustomerIdReply> Handle(GetOrdersByCustomerIdRequest request)
        {
            var validationResult = await new GetOrdersByCustomerIdRequestValidator().ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                throw new InvalidOperationException("Request has validation errors");
            }

            var result = await _orderService.GetOrdersByCustomerIdAsync(request.CustomerId);
            return _mapper.Map<GetOrdersByCustomerIdReply>(result);
        }
    }
}