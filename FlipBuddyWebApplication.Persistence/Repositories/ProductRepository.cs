using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Persistence.Abstractions;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.CategoryResponses;
using FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses;
using System;

namespace FlipBuddyWebApplication.Persistence.Repositories
{
    public class ProductRepository : RepositoryBase
    {
        public ProductRepository(ExternalApiService externalApiService) : base(externalApiService)
        {
        }

        public async Task<List<Product>> GetProductsByUserGuid(string guid) 
        { 
            var response = (await _externalApiService.GetAPIResponse<GetProductsByUserGuidResponse>($"https://localhost:7294/Product/GetProductsByUserGuid?UserGuid={guid}"));
            ArgumentNullException.ThrowIfNull(response.products);
			var result = response.products.Select(_ => _.AsDomainProduct()).ToList();
			return result;
        }

       
        public async Task<HttpResponseMessage> InsertProduct(object request) => await _externalApiService.PostAPIRequest("https://localhost:7294/Product/InsertProduct", request);
    }
}
