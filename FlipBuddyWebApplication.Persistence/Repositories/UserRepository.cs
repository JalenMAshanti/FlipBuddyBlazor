using FlipBuddyWebApplication.Domain.Constants;
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

		public async Task<User> GetUserByGuidAsync(string guid) => (await _externalApiService.GetAPIResponse<GetUserByGuidResponse>($@"{Hidden.baseApiUrl}{Hidden.GetUserByGuidEndpoint(guid)}")).AsDomainUser();

		public async Task<HttpResponseMessage> DeleteUserByGuidAsync() => await _externalApiService.DeleteAPIRequest($@"{Hidden.baseApiUrl}{Hidden.DeleteUserByGuidEndpoint}");

		public async Task<HttpResponseMessage> InsertUserByGuidAsync(object instance) => await _externalApiService.PostAPIRequest($@"{Hidden.baseApiUrl}{Hidden.InsertUserEndpoint}", instance);
	}
}
