using FlipBuddyWebApplication.Domain.Constants;
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

		public async Task<List<Product>> GetProductsByUserGuid(string guid)
		{
			var response = (await _externalApiService.GetAPIResponse<GetProductsByUserGuidResponse>($@"{Hidden.baseApiUrl}{Hidden.GetProductsByUserGuidEndpoint(guid)}"));
			ArgumentNullException.ThrowIfNull(response.products);
			var result = response.products.Select(_ => _.AsDomainProduct()).ToList();
			return result;
		}

		public async Task<HttpResponseMessage> InsertProduct(object request) => await _externalApiService.PostAPIRequest($@"{Hidden.baseApiUrl}{Hidden.InsertProductEndpoint}", request);

		public string GetCategory(int categoryId, List<Category> categories) => categories.Where(_ => _.CategoryId == categoryId).Select(x => x.Name).FirstOrDefault()!.ToString();

		public string GetCondition(int conditionId, List<Condition> conditions) => conditions.Where(_ => _.ConditionId == conditionId).Select(x => x.ConditionTitle + " " + x.Description).FirstOrDefault()!.ToString();

		public async Task<HttpResponseMessage> InsertProductByBarcode(InsertProductByImageRequest request) => await _externalApiService.PostAPIRequest($"https://localhost:7294/Product/UploadBarcode", request);

		public async Task<Product> GetProductByGuidAndUserGuid(string userGuid, string productGuid) => (await _externalApiService.GetAPIResponse<GetProductByGuidAndUserGuidResponse>($@"{Hidden.baseApiUrl}{Hidden.GetProductByGuidAndUserGuidEndpoint(productGuid, userGuid)}")).AsDomainProduct();

		public async Task<HttpResponseMessage> UpdateProductByGuidAndUserGuid(UpdateProductByGuidAndUserGuidRequest request) => await _externalApiService.PutAPIRequest($@"{Hidden.baseApiUrl}{Hidden.UpdateProductByGuidAndUserGuidEndpoint}", request);
	}
}
