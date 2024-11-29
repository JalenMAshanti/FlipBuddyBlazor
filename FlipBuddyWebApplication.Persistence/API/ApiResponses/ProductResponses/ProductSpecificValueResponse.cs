using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ProductResponses
{
    public class ProductSpecificValueResponse
    {
        public int valueId { get; set; }
        public int specificId { get; set; }
        public string specificValue { get; set; } = string.Empty;

        public ProductSpecificValue AsDomainProductSpecificValue() => new(valueId, specificId, specificValue);
    }
}
