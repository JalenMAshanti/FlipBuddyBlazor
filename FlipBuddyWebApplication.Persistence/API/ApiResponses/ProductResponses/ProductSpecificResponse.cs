using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{
    public class ProductSpecificResponse
    {
        public int specificId { get; set; }
        public string specificName { get; set; } = string.Empty;
        public List<ProductSpecificValueResponse> values { get; set; } = new List<ProductSpecificValueResponse>();  
        public ProductSpecific AsDomainProductSpecific() => new ProductSpecific(specificId, specificName, values.Select(_ => _.AsDomainProductSpecificValue()).ToList(), true);
    }
}
