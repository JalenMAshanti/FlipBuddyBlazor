﻿using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPriceItem.Response
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(AddFixedPriceItemResponse));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (AddFixedPriceItemResponse)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "AddFixedPriceItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
	public class AddFixedPriceItemResponse
	{
		[XmlElement(ElementName = "Timestamp")]
		public DateTime Timestamp { get; set; }

		[XmlElement(ElementName = "Ack")]
		public string Ack { get; set; } = string.Empty;

		[XmlElement(ElementName = "Version")]
		public int Version { get; set; }

		[XmlElement(ElementName = "Build")]
		public string Build { get; set; } = string.Empty;

		[XmlElement(ElementName = "ItemID")]
		public double ItemID { get; set; }

		[XmlElement(ElementName = "StartTime")]
		public DateTime StartTime { get; set; }

		[XmlElement(ElementName = "EndTime")]
		public DateTime EndTime { get; set; }

		[XmlElement(ElementName = "Fees")]
		public Fees? Fees { get; set; }

		[XmlElement(ElementName = "DiscountReason")]
		public string DiscountReason { get; set; } = string.Empty;

		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; } = string.Empty;

		[XmlText]
		public string Text { get; set; } = string.Empty;
	}
}
