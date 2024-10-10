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

        public async Task<LoginAPIResponse> Login(LoginRequest request) => await _externalApiService.GetAPIResponse<LoginAPIResponse>($"https://localhost:7294/Login/LoginByUsernameAndPassword?Username={request.Username}&Password={request.Password}");
    }
}
