using NatsExtensions.Services;
using OrderService.Contract.Messages;
using ProductService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Adapters
{
    public class ProductServiceAdapter : IProductServiceAdapter
    {
        private readonly INatsService _natsService;

        public ProductServiceAdapter(INatsService natsService)
        {
            _natsService = natsService;
        }

        public GetProductsByIdsReply GetProductsByIds(GetProductsByIdsRequest request)
        {
            return _natsService.RequestReply<GetProductsByIdsRequest, GetProductsByIdsReply>(
                request: request, 
                subject: ServiceBusSubjects.ProductSubject);
        }
    }
}