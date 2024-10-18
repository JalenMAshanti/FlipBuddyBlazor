using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.ConditionResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
	public class ConditionRepository : RepositoryBase
	{
		public ConditionRepository(ExternalApiService externalApiService) : base(externalApiService)
		{
		}

		public async Task<List<Condition>> GetAllConditions()
		{
			var response = (await _externalApiService.GetAPIResponse<GetAllConditionsResponse>("https://localhost:7294/Category/GetAllConditions"));
			ArgumentNullException.ThrowIfNull(response.conditions);
			var result = response.conditions.Select(_ => _.AsDomainCondition()).ToList();
			return result;
		}
	}
}
