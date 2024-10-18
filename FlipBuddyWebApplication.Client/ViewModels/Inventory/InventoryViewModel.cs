using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory
{
    public class InventoryViewModel
    {
        public List<Product>? MyProducts { get; set; }
        public List<Category>? AllCategories { get; set; }

    }
}
