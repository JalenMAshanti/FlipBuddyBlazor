using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory.ItemDisplay
{
    public class ItemDisplayViewModel
    {
        public string UserGuid { get; set; } = string.Empty;
        public string ProductGuid { get; set; } = string.Empty ;
        public string CurrentDisplayMode { get; set; } = "ViewMode";
        public List<Condition> Conditions { get; set; } = new List<Condition>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public bool isLoading { get; set; } = true;





        public void IsStillLoading(Product currentProduct)
        {
            if (currentProduct == null)
            {
                isLoading = true;
            }
            else
            {
                isLoading = false;
            }
        }  
    }
}
