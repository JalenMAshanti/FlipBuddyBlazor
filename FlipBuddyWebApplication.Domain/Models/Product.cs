using System.Reflection;

namespace FlipBuddyWebApplication.Domain.Models
{
	public class Product
	{
		public Product() { }

		public string Title { get; set; } = string.Empty;
		public int CategoryId { get; set; }
		public decimal PurchasePrice { get; set; }
		public decimal SellPrice { get; set; }
		public string Description { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public string Currency { get; set; } = string.Empty;
		public int ConditionId { get; set; }
		public int Barcode { get; set; }
	}
}
