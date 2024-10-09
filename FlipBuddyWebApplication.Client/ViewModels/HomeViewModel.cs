using FlipBuddyWebApplication.Persistence.API.ApiResponses;
using FlipBuddyWebApplication.Domain.Models;
namespace FlipBuddyWebApplication.Client.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel() { }

		public User? User { get; set; }
		//public EarningStats Earnings { get; set; }
		public List<Product>? RecentlyListedItems { get; set; }
	}
}
