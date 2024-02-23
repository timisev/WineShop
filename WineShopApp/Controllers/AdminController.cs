using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using WineShopApp.Models;

namespace WineShopApp.Controllers
{
    public class AdminController : Controller
    {
        private IWineRepository repository;

        public AdminController(IWineRepository repo)
        {
            this.repository = repo;
        }

        public ViewResult Index() =>
            View(repository.Wines);

        public IActionResult Edit(int id) =>
            View(repository.Wines.FirstOrDefault(w => w.Id == id));

        [HttpPost]
        public IActionResult Edit(Wine wine)
        {
            if (ModelState.IsValid)
            {
                repository.Add(wine);
                return RedirectToAction("Index");
            }
            return View(wine);
        }

        public IActionResult Create() => View("Edit", new Wine());

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
