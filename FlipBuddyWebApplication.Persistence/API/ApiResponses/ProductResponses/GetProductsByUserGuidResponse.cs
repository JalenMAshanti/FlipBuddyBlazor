using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{
	public class ProductResponse
	{
		public string guid { get; set; } = string.Empty;
		public string? userGuid { get; set; } = string.Empty;
		public string title { get; set; } = string.Empty;
		public int categoryId { get; set; }
		public int ebayCategoryId { get; set; }
		public decimal purchasedPrice { get; set; }
		public decimal sellPrice { get; set; }
		public string description { get; set; } = string.Empty;
		public int quantity { get; set; }
		public string currency { get; set; } = string.Empty;
		public int conditionId { get; set; }
		public string barCode { get; set; } = string.Empty;
		public string dateSold { get; set; } = string.Empty;

		public Product AsDomainProduct() => new(guid, title, categoryId, ebayCategoryId, purchasedPrice, sellPrice, description, quantity, currency, conditionId, barCode, dateSold);
	}

	public class GetProductsByUserGuidResponse
	{
		public List<ProductResponse>? products { get; set; }
	}

}
