
namespace WineShopApp.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;

        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders;

        public void Save(Order order)
        {
            if(order != null)
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
            else
            { 
            }
        }
    }
}
