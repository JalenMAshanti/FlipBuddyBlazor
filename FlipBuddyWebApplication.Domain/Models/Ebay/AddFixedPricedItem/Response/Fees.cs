using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPriceItem.Response
{
	[XmlRoot(ElementName = "Fees")]
	public class Fees
	{
		[XmlElement(ElementName = "Fee")]
		public List<Fee> Fee { get; set; } = new List<Fee>();	
	}
}
