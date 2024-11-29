using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlipBuddyWebApplication.Domain.Models
{
	public class InsertProductRequest
	{
		public Guid Guid { get; set; } 
		
		public string UserGuid { get; set; } = string.Empty;
		
		[Required]
		public string Title { get; set; } = string.Empty;

		[Required]
		public int CategoryId { get; set; }

		[Required]
		public int EbayCategoryId { get; set; }
			
		[Required]
		public decimal PurchasedPrice { get; set; }

		[Required]
		public decimal SellPrice { get; set; }

		[Required]
		[StringLength(300)]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Range(1, 100)]
		public int Quantity { get; set; } = 1;

		public string Currency { get; set; } = string.Empty;

		public int ConditionId { get; set; }

		public string BarCode { get; set; } = string.Empty;

		[JsonPropertyName("specifics")]
		public List<Specific> ProductSpecifics { get; set; } = new List<Specific>();
	}
}
