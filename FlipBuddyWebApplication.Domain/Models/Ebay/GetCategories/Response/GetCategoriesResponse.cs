using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GetCategories.Response
{

	[XmlRoot(ElementName = "GetCategoriesResponse")]
	public class GetCategoriesResponse
	{

		[XmlElement(ElementName = "Timestamp")]
		public DateTime Timestamp { get; set; }

		[XmlElement(ElementName = "Ack")]
		public string Ack { get; set; }

		[XmlElement(ElementName = "Version")]
		public int Version { get; set; }

		[XmlElement(ElementName = "Build")]
		public string Build { get; set; }

		[XmlElement(ElementName = "CategoryArray")]
		public CategoryArray CategoryArray { get; set; }

		[XmlElement(ElementName = "CategoryCount")]
		public int CategoryCount { get; set; }

		[XmlElement(ElementName = "UpdateTime")]
		public DateTime UpdateTime { get; set; }

		[XmlElement(ElementName = "CategoryVersion")]
		public int CategoryVersion { get; set; }

		[XmlElement(ElementName = "ReservePriceAllowed")]
		public bool ReservePriceAllowed { get; set; }

		[XmlElement(ElementName = "MinimumReservePrice")]
		public double MinimumReservePrice { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
