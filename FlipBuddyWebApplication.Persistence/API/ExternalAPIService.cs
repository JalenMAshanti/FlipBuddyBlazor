using FlipBuddyWebApplication.Persistence.API.Abstractions;
using FlipBuddyWebApplication.Persistence.Factories;

namespace FlipBuddyWebApplication.Persistence.API
{
    public class ExternalApiService : APIService
    {
        public ExternalApiService(ClientFactory clientFactory) : base( clientFactory)
        {
        }
    }
}
