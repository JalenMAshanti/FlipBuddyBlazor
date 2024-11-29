namespace FlipBuddyWebApplication.Domain.Models
{
    public class ProductSpecific
    {
        public ProductSpecific(int specificId, string specificName, List<ProductSpecificValue> values, bool isRequired) 
        {
            SpecificId = specificId;
            SpecificName = specificName;
            Values = values;
            IsRequired = isRequired;
        }

        public int SpecificId { get; set; }
        public string SpecificName { get; set; } = string.Empty;
        public List<ProductSpecificValue>? Values { get; set; }
        public bool IsRequired { get; set; } = false;
    }
}
