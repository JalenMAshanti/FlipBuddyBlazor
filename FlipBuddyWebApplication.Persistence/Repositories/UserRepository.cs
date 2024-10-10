using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.UserResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
	public class UserRepository : RepositoryBase
	{
		public UserRepository(ExternalApiService externalApiService) : base(externalApiService)
		{
		}

		public async Task<User> GetUserByGuidAsync(Guid guid) => (await _externalApiService.GetAPIResponse<GetUserByGuidResponse>($"https://localhost:7294/User/GetUserByGuid?UserGuid={guid}")).AsDomainUser();

		public async Task<HttpResponseMessage> DeleteUserByGuidAsync() => await _externalApiService.DeleteAPIRequest("https://localhost:7294/User/DeleteUserByGuid");

		public async Task<HttpResponseMessage> InsertUserByGuidAsync(object instance) => await _externalApiService.PostAPIRequest("https://localhost:7294/User/InsertUser", instance);
	}
}
