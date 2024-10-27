using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory.ItemDisplay
{
    public class ItemDisplayClient
    {
        public readonly ProductRepository _productRepository;

        public readonly CategoryRepository _categoryRepository;

        public ItemDisplayClient( ProductRepository productRepository, CategoryRepository categoryRepository) 
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

		
	}
}
