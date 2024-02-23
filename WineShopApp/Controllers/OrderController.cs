using Microsoft.AspNetCore.Mvc;
using WineShopApp.Models;

namespace WineShopApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repo)
        {
            repository = repo;
        }

        public IActionResult Checkout(int id) =>
            View(repository.Orders.FirstOrDefault(o => o.OrderID == id));

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(ModelState.IsValid)
            {
                repository.Save(order);
                return RedirectToAction();
            }
            return View(order);
        }
    }
}
