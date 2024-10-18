using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Domain.Models;
namespace FlipBuddyWebApplication.Client.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public string? UserGuid { get; set; } = "3fa85f64-5717-4562-b3fc-2c963f66afa6";
        public User User { get; set; } = new User();
        public List<Product>? SoldItems { get; set; }
        public List<Product>? ItemsInInventory { get; set; }
        public List<Product>? RecentlyListedItems { get; set; }
        public List<Category>? TopSellingCategories { get; set; }
    }
}
