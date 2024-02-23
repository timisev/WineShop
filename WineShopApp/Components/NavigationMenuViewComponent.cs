using Microsoft.AspNetCore.Mvc;
using WineShopApp.Models;

namespace WineShopApp.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IWineRepository repository;

        public NavigationMenuViewComponent(IWineRepository repo)
        {
            this.repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Wines
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
