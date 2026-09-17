namespace GetTheRepsWeb.Persistance.Models
{
    public class RatingModel
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
