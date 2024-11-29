using System.Xml.Serialization;
using FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse;
using FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ShippingServiceDetailsResponse;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.Root
{

    [XmlRoot(ElementName = "GeteBayDetailsResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GeteBayDetailsResponse
    {

        [XmlElement(ElementName = "Timestamp")]
        public DateTime Timestamp { get; set; }

        [XmlElement(ElementName = "Ack")]
        public string Ack { get; set; }

        [XmlElement(ElementName = "Version")]
        public int Version { get; set; }

        [XmlElement(ElementName = "Build")]
        public string Build { get; set; }

        [XmlElement(ElementName = "ReturnPolicyDetails")]
        public ReturnPolicyDetails ReturnPolicyDetails { get; set; }

        [XmlElement(ElementName = "ShippingServiceDetails")]
        public List<ShippingServiceDetails> ShippingServiceDetails { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
