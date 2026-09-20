using GetTheRepsWeb.Application.DTO;
using GetTheRepsWeb.Domain.Aggregates.Entities;

namespace GetTheRepsWeb.Application.Services
{
    public interface IProductServices
    {
        public Task<IReadOnlyCollection<Product>> ViewProductsAsync(ViewProductDto query);
    }
}