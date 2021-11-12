using NatsExtensions.Proxies;
using NatsExtensions.Services;
using OrderService.BusinessLogic.Models;

namespace OrderService.BusinessLogic.Proxies
{
    public class ProductServiceProxy : BaseProxy<GetProductsByIdsRequest, GetProductsByIdsReply>
    {
        public ProductServiceProxy(INatsService natsService) : base(natsService) { }
    }
}