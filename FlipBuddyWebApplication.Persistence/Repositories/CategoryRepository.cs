using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.CategoryResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
	public class CategoryRepository : RepositoryBase
	{
		public CategoryRepository(ExternalApiService externalApiService) : base(externalApiService)
		{
		}

		public async Task<List<Category>> GetAllCategories()
		{
			var response = (await _externalApiService.GetAPIResponse<GetAllCategoriesAPIResponse>("https://localhost:7294/Category/GetAllCategories"));
			ArgumentNullException.ThrowIfNull(response.categories);
			var result = response.categories.Select(_ => _.AsDomainCategory()).ToList();
			return result;
		}
	}
}
