using System.ComponentModel.DataAnnotations;

namespace GetTheRepsWeb.Presentation.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
