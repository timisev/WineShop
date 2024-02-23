using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WineShopApp.Models;
using WineShopApp.Models.ViewModels;

namespace WineShopApp.Controllers
{
    public class HomeController : Controller
    {
        private IWineRepository repository;
        public int PageSize = 4;

        public HomeController(IWineRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult List(string category, int winePage = 1)
        {
            return View(new WineListViewModel
            {
                Wines = repository.Wines
                    .OrderBy(w => w.Id)
                    .Skip((winePage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = winePage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Wines.Count()
                },
                CurrentCategory = category
            });
        } 

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = repository.Wines.FirstOrDefault(w => w.Id == id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        public async Task<IActionResult> Search(string? name)
        {
            if(repository.Wines == null)
            {
                return Problem("The wine not found");
            }

            var wines = from w in repository.Wines
                        select w;

            if (!String.IsNullOrEmpty(name))
            {
                wines = wines.Where(w => w.Name!.Contains(name));
            }

            return View(await wines.ToListAsync());
        }
    }
}
