using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GetTheRepsWeb.Persistance.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
