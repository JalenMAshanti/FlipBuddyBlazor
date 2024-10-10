using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.Factories;

namespace FlipBuddyWebApplication.Persistence.Abstractions
{
    public abstract class RepositoryBase
    {
        protected readonly ExternalApiService _externalApiService;
        public RepositoryBase(ExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }
    }
}
