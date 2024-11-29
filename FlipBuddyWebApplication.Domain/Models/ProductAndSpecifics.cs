namespace FlipBuddyWebApplication.Domain.Models
{
	public class ProductAndSpecifics
	{
		public ProductAndSpecifics(Product product, List<ProductSpecific> productSpecifics) 
		{
			Product = product;
			ProductSpecifics = productSpecifics;
		}

		public Product Product { get; set; }
		public List<ProductSpecific>? ProductSpecifics { get; set; }
	}
}
