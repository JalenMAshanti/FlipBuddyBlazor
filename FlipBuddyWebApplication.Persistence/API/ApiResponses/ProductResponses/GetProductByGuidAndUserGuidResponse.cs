using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{
    public class GetProductByGuidAndUserGuidResponse
    {
        public ProductResponse product { get; set; }

        public List<ProductSpecificResponse> productSpecifics { get; set; } = new List<ProductSpecificResponse>();

        private Product AsDomainProduct() => new(product.guid, product.title, product.categoryId, product.ebayCategoryId, product.purchasedPrice, product.sellPrice, product.description, product.quantity, product.currency, product.conditionId, product.barCode, product.dateSold);

        private List<ProductSpecific> AsDomainProductSpecifics() => productSpecifics.Select(_=>_.AsDomainProductSpecific()).ToList();

        public ProductAndSpecifics AsDomainProductAndSpecific() => new(AsDomainProduct(), AsDomainProductSpecifics());
    }
}
