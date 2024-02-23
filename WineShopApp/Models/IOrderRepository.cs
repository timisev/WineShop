namespace WineShopApp.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void Save(Order order);
    }
}
