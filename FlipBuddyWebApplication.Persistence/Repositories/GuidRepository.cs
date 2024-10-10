using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.GuidResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
	public class GuidRepository : RepositoryBase
	{
		public GuidRepository(ExternalApiService externalApiService) : base(externalApiService)
		{
		}

		public Guid GetNewGuid() => Guid.NewGuid();	 
	}
}
