using GetTheRepsWeb.Application.DTO;
using GetTheRepsWeb.Domain.Entities;
using System.Collections.ObjectModel;

// the service accepts a dto
// the service maps the use-case
// the service uses the repository
// the repository returns domain entities
// the service returns domain entities to the controller
// the controller maps the domain to the view model

namespace GetTheRepsWeb.Application.Services
{
    public class ProductPageService : IProductServices
    {
        public async ReadOnlyCollection<Product> ViewProductsAsync(ViewProductDto query)
        {

        }

    }
}
