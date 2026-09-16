using GetTheRepsWeb.Domain.Enums;

namespace GetTheRepsWeb.Presentation.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public List<ProductCategory> CategoryFilter { get; set; }
        public ProductCategory SelectedCategory { get; set; }
        public List<SortingOption> SortingOptions { get; set; }
        public SortingOption SelectedSoritingOption { get; set; }
        public int MaxProductsDisplayed { get; set; }
    }
}