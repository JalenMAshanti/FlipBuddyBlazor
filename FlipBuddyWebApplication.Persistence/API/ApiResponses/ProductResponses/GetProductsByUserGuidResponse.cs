using FlipBuddyWebApplication.Domain.Models;
using System.Globalization;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{
    public class ProductResponse
    {
        public string guid { get; set; } = string.Empty;
        public string? userGuid { get; set; } = string.Empty;
        public string title { get; set; }= string.Empty;
        public int categoryId { get; set; }
        public decimal purchasedPrice { get; set; }
        public decimal sellPrice { get; set; }
        public string description { get; set; } = string.Empty;
        public int quantity { get; set; }
        public string currency { get; set; } = string.Empty;
        public int conditionId { get; set; }
        public string barCode { get; set; } = string.Empty;

        public Product AsDomainProduct() => new(title, categoryId, purchasedPrice, sellPrice, description, quantity, currency, conditionId, barCode, "");
    }

    public class GetProductsByUserGuidResponse
    {
        public List<ProductResponse>? products { get; set; }
    }



}
