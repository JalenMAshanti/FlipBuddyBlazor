using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{

    public class GetProductByGuidAndUserGuidResponse
    {
        public ProductResponse product { get; set; }

        public Product AsDomainProduct() => new(product.guid, product.title, product.categoryId, product.purchasedPrice, product.sellPrice, product.description, product.quantity, product.currency, product.conditionId, product.barCode, product.dateSold);
    }
}
