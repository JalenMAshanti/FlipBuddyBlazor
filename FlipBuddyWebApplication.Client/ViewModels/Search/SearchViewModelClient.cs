using FlipBuddyWebApplication.Client.ViewModels.Abstractions;
using FlipBuddyWebApplication.Persistence.Repositories;

namespace FlipBuddyWebApplication.Client.ViewModels.Search
{
	public class SearchViewModelClient : BaseClient
	{
		public readonly CategoryRepository _categoryRepository;

		public SearchViewModelClient(CategoryRepository categoryRepository) 
		{ 
			_categoryRepository = categoryRepository; 
		}
	}
}
