using FlipBuddyWebApplication.Client.ViewModels.Home;
using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.TopCategories
{
    public class TopCategoriesClient
    {
        public readonly ProductRepository _productRepository;
        public TopCategoriesClient(ProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
    }
}
