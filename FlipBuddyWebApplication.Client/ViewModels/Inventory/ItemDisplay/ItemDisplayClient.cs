using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory.ItemDisplay
{
    public class ItemDisplayClient
    {
        public readonly ProductRepository _productRepository;

        public readonly CategoryRepository _categoryRepository;

        public readonly EbayRepository _ebayRepository;

        public ItemDisplayClient( ProductRepository productRepository, CategoryRepository categoryRepository, EbayRepository ebayRepository) 
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _ebayRepository = ebayRepository;
        }

		
	}
}
