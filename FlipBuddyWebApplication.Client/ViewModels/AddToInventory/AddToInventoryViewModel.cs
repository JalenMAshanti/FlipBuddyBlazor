using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Client.ViewModels.AddToInventory
{
    public class AddToInventoryViewModel : BaseViewModel
	{
		public List<Condition>? Conditions { get; set; }
		public List<Category>? Categories { get; set; }
	}
}
