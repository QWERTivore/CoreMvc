using System.ComponentModel.DataAnnotations;

namespace GetTheRepsWeb.Presentation.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

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
