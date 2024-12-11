using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Domain.Models.Ebay.GetCategories.Response;
using FlipBuddyWebApplication.Domain.Models.Ebay.GetItemAspectsForCategory.Response;

namespace FlipBuddyWebApplication.Client.ViewModels.AddToInventory
{
    public class AddToInventoryViewModel : BaseViewModel
	{
		public string? AccessToken { get; set; }
		public List<Condition>? Conditions { get; set; }
		public List<Category>? Categories { get; set; }
		public GetCategoriesResponse EbayCategories { get; set; } = new GetCategoriesResponse();
		
		public List<EbayCategory> EbayCategoriesLevel1 { get; set; } = new List<EbayCategory>();
		public int? SelectedCategoryLevel1Id { get; set; } 

		public List<EbayCategory> EbayCategoriesLevel2 { get; set; } = new List<EbayCategory>();

		public int? SelectedCategoryLevel2Id { get; set; }

		public List<EbayCategory> EbayCategoriesLevel3 { get; set; } = new List<EbayCategory>();

		public int? SelectedCategoryLevel3Id { get; set; }

		public List<EbayCategory> EbayCategoriesLevel4 { get; set; } = new List<EbayCategory>();

		public int? SelectedCategoryLevel4Id { get; set; }

		public Aspects? RequiredItemSpecifics { get; set; } 
	}
}
