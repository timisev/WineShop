namespace WineShopApp.Models
{
    public interface IWineRepository
    {
        IQueryable<Wine> Wines { get; }
        IQueryable<Category> Categories {  get; }
        void Add(Wine wine);
        void Delete(int id);
    }
}
