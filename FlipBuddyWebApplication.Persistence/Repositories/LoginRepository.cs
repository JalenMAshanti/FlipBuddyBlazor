using FlipBuddyWebApplication.Domain.Constants;
using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.LoginResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
    public class LoginRepository : RepositoryBase
    {
        public LoginRepository(ExternalApiService externalApiService) : base(externalApiService)
        {
        }

        public async Task<LoginAPIResponse> Login(LoginRequest request) => await _externalApiService.GetAPIResponse<LoginAPIResponse>($@"{Hidden.baseApiUrl}{Hidden.LoginEndpoint(request.Username, request.Password)}");
    }
}
