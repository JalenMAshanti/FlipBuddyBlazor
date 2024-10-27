using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Persistence.Repositories;
using Microsoft.AspNetCore.Components;

namespace FlipBuddyWebApplication.Client.ViewModels.AddToInventory
{
	public class AddToInventoryViewModelClient : BaseClient
	{
		public readonly NavigationManager _navigationManager;
		public readonly CategoryRepository _categoryRepository;
		public readonly ConditionRepository _conditionRepository;
		public readonly ProductRepository _productRepository;
		public AddToInventoryViewModelClient(NavigationManager navigationManager,
											CategoryRepository categoryRepository,
											ConditionRepository conditionRepository,
											ProductRepository productRepository)
		{
			_navigationManager = navigationManager;
			_categoryRepository = categoryRepository;
			_conditionRepository = conditionRepository;
			_productRepository = productRepository;
		}
	}
}
