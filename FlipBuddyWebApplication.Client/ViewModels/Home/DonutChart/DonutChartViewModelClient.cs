using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Home.DonutChart
{
    public class DonutChartViewModelClient
    {
        public readonly ProductRepository _productRepository;
        public readonly CategoryRepository _categoryRepository;
       
        public DonutChartViewModelClient(ProductRepository productRepository, CategoryRepository categoryRepository) 
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
    }
}
