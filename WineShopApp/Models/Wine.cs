using System.ComponentModel.DataAnnotations;

namespace WineShopApp.Models
{
    public class Wine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Year { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
