using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
    public class ProductRepository : RepositoryBase
    {
        public ProductRepository(ExternalApiService externalApiService) : base(externalApiService)
        {
        }

        public async Task<List<Product>> GetProductsByUserGuid(string guid) => (await _externalApiService.GetListAPIResponse<GetProductsByUserGuidResponse>($"https://localhost:7294/Product/GetProductsByUserGuid?UserGuid={guid}")).Select(_ => _.AsDomainProduct()).ToList();

        public async Task<HttpResponseMessage> InsertProduct(object request) => await _externalApiService.PostAPIRequest("https://localhost:7294/Product/InsertProduct", request);
    }
}
