﻿using FlipBuddyWebApplication.Domain.Constants;
using FlipBuddyWebApplication.Domain.Models;
using FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPriceItem.Response;
using FlipBuddyWebApplication.Domain.Models.Ebay.ListingOptionsModel;
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

		public string GetCategory(int categoryId, List<Category> categories) 
		{
			try
			{
				var category = categories.Where(_ => _.CategoryId == categoryId).Select(x => x.Name).FirstOrDefault()!.ToString();
				return category;
			}
			catch (Exception ex)
			{
				return "error";
			}			
		}

		public bool IsProductReady(Product product)
		{
			if (product.EbayCategoryId == null || product.CategoryId == 22 || product.SellPrice <= 0)
			{
				return false;
			}
			else 
			{
				return true;	
			}
		}

		public string GetCondition(int conditionId, List<Condition> conditions) => conditions.Where(_ => _.ConditionId == conditionId).Select(x => x.ConditionTitle + " " + x.Description).FirstOrDefault()!.ToString();

		public async Task<HttpResponseMessage> InsertProductByBarcode(InsertProductByImageRequest request) => await _externalApiService.PostAPIRequest($"https://localhost:7294/Product/UploadBarcode", request);

		public async Task<ProductAndSpecifics> GetProductByGuidAndUserGuid(string userGuid, string productGuid) => (await _externalApiService.GetAPIResponse<GetProductByGuidAndUserGuidResponse>($@"{Hidden.baseApiUrl}{Hidden.GetProductByGuidAndUserGuidEndpoint(productGuid, userGuid)}")).AsDomainProductAndSpecific();

		public async Task<HttpResponseMessage> UpdateProductByGuidAndUserGuid(UpdateProductByGuidAndUserGuidRequest request) => await _externalApiService.PutAPIRequest($@"{Hidden.baseApiUrl}{Hidden.UpdateProductByGuidAndUserGuidEndpoint}", request);

		public async Task<HttpResponseMessage> DeleteProductByProductGuid(string productGuid) => await _externalApiService.DeleteAPIRequest($@"{Hidden.baseApiUrl}{Hidden.DeleteProductByProductGuid(productGuid)}");

		public async Task<double> ListFromInventoryToEbay(EbayListingOptions listing) => await _externalApiService.PostAPIRequestEbayListing($@"{Hidden.baseApiUrl}{Hidden.ListToEbayEndpoint}", listing);
	}
}
