using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.Root;

namespace FlipBuddyWebApplication.Client.ViewModels.Inventory.ItemDisplay
{
    public class ItemDisplayViewModel
	{
		public string UserGuid { get; set; } = string.Empty;
		public string ProductGuid { get; set; } = string.Empty;
		public string CurrentDisplayMode { get; set; } = "ViewMode";
		public List<Condition> Conditions { get; set; } = new List<Condition>();
		public List<Category> Categories { get; set; } = new List<Category>();
		public List<string> Images { get; set; } = new List<string>();
		public bool isLoading { get; set; } = true;
		public GeteBayDetailsResponse EbayShippingDetails { get; set; }	
		public GeteBayDetailsResponse EbayReturnDetails { get; set; }




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
