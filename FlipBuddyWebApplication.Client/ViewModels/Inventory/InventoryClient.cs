using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory
{
    public class InventoryClient
    {
        public readonly ProductRepository _productRepository;

        public InventoryClient(ProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }  
    }
}
