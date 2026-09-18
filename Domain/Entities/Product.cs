using GetTheRepsWeb.Domain.Enums;
using GetTheRepsWeb.Domain.Exceptions;
using GetTheRepsWeb.Domain.ValueObjects;

namespace GetTheRepsWeb.Domain.Entities
{
    public class Product
    {
        private readonly List<Rating> _ratings = new();
        public string Name { get; private set; }
        public ProductCategory Category { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public IReadOnlyCollection<Rating> Ratings => _ratings.AsReadOnly();

        public Product(string name, ProductCategory category, decimal price, int quantity)
        {
            SetName(name);
            SetCategory(category);
            SetPrice(price);
            SetQuantity(quantity);
        }

        public void AddRating(int stars)
        {
            if (stars < 1 || stars > 5)
                throw new InvalidRatingException("Rating must be between 1 and 5.");

            _ratings.Add(new Rating(stars));
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new InvalidProductDataException("Name cannot be empty.");

            Name = name;
        }

        private void SetCategory(ProductCategory category)
        {
            Category = category;
        }

        private void SetPrice(decimal price)
        {
            if (price < 0)
                throw new InvalidProductDataException("Price cannot be negative.");

            Price = price;
        }

        private void SetQuantity(int quantity)
        {
            if (quantity < 0)
                throw new InvalidProductDataException("Quantity cannot be negative.");

            Quantity = quantity;
        }
    }

}
