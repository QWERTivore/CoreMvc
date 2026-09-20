using GetTheRepsWeb.Domain.Aggregates.Entities;

namespace GetTheRepsWeb.Application.DTO
{
    public class ViewProductDto
    {
        public ProductCategory? Category { get; set; }
        public int MaxProducts { get; set; }

    }
}
