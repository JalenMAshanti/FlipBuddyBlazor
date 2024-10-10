using System.Reflection;

namespace FlipBuddyWebApplication.Domain.Models
{
	public class Product
	{
		public Product(string title,
						int categoryId,
						decimal puchasePrice,
						decimal sellPrice,
						string description,
						int quantity,
						string currency,
						int conditionId,
						int barcode,
						DateOnly dateSold) 
		{
			Title = title;
			CategoryId = categoryId;
			PurchasePrice = puchasePrice;
			SellPrice = sellPrice;
			Description = description;
			Quantity = quantity;
			Currency = currency;
			ConditionId = conditionId;
			Barcode = barcode;
			DateSold = dateSold;
		}

		public string Title { get; set; } = string.Empty;
		public int CategoryId { get; set; }
		public decimal PurchasePrice { get; set; }
		public decimal SellPrice { get; set; }
		public string Description { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public string Currency { get; set; } = string.Empty;
		public int ConditionId { get; set; }
		public int Barcode { get; set; }
		public DateOnly DateSold { get; set; }	
	}
}
