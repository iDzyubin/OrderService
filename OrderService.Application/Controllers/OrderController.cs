using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderService.BusinessLogic.Models;
using OrderService.Contract.Entities;
using OrderService.Contract.Interfaces;

namespace OrderService.Application.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<GetOrdersReply>> GetOrders(GetOrdersRequest request)
        {
            try
            {
                var result = await _orderService.GetAllOrdersAsync();
                return Ok(_mapper.Map<GetOrdersReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<GetOrdersByCustomerIdReply>> GetOrdersByCustomerId(GetOrdersByCustomerIdRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _orderService.GetOrdersByCustomerIdAsync(request.CustomerId);
                return Ok(_mapper.Map<GetOrdersByCustomerIdReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<GetOrderByIdReply>> GetOrderById(GetOrderByIdRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _orderService.GetOrderByIdAsync(request.OrderId);
                return Ok(_mapper.Map<GetOrderByIdReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<CreateOrderReply>> CreateOrder(CreateOrderRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _orderService.CreateOrderAsync(_mapper.Map<Order>(request));
                return Ok(_mapper.Map<CreateOrderReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<UpdateOrderReply>> UpdateOrder(UpdateOrderRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _orderService.UpdateOrderAsync(_mapper.Map<Order>(request));
                return Ok(_mapper.Map<UpdateOrderReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<DeleteOrderReply>> DeleteOrder(DeleteOrderRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                var result = await _orderService.DeleteOrderAsync(request.OrderId);
                return Ok(_mapper.Map<DeleteOrderReply>(result));
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}