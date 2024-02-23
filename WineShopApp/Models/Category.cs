using System.ComponentModel.DataAnnotations;

namespace WineShopApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Wine> Wines { get; set; }
    }
}
