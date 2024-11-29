using FlipBuddyWebApplication.Persistence.API.Abstractions;
using FlipBuddyWebApplication.Persistence.Factories;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
    public class EbayRepository : EbayAPIService
    {
        public EbayRepository(ClientFactory clientFactory) : base(clientFactory)
        {
        }
    }
}
