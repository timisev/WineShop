
namespace WineShopApp.Models
{
    public class EFWineRepository : IWineRepository
    {
        private ApplicationDbContext context; 

        public EFWineRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Wine> Wines => context.Wines;

        public IQueryable<Category> Categories => context.Categories;

        public void Add(Wine wine)
        {
            if(wine == null)
            {
                context.Wines.Add(wine);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            if(id != 0)
            {
                Wine wine = context.Wines.FirstOrDefault(w => w.Id == id);
                context.Wines.Remove(wine);
                context.SaveChanges();
            }
        }
    }
}
