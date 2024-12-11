using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPriceItem.Response
{
	[XmlRoot(ElementName = "Fee")]
	public class Fee
	{
		[XmlAttribute(AttributeName = "currencyID")]
		public string CurrencyID { get; set; } = string.Empty;

		[XmlText]
		public string Text { get; set; }

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; } = string.Empty;
	}
}
