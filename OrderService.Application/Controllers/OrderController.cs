using Microsoft.AspNetCore.Mvc;

namespace OrderService.Application.Controllers
{
    public class OrderController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}