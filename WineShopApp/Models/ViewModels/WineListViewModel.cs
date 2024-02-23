namespace WineShopApp.Models.ViewModels
{
    public class WineListViewModel
    {
        public IEnumerable<Wine> Wines { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
