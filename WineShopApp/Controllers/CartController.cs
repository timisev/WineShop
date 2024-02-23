using Microsoft.AspNetCore.Mvc;
using WineShopApp.Models;
using WineShopApp.Models.ViewModels;
using WineShopApp.Infrastructure;

namespace WineShopApp.Controllers
{
    public class CartController : Controller
    {
        private IWineRepository repository;
        private Cart cart;

        public CartController(IWineRepository repository, Cart cart)
        {
            this.repository = repository;
            this.cart = cart;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int wineId, string returnUrl)
        {
            Wine wine = repository.Wines
                .FirstOrDefault(w => w.Id == wineId);
            if(wine != null)
            {
                cart.AddItem(wine, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int wineId, string returnUrl)
        {
            Wine wine = repository.Wines
                .FirstOrDefault(w => w.Id == wineId);

            if(wine != null)
            {
                cart.RemoveLine(wine);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}