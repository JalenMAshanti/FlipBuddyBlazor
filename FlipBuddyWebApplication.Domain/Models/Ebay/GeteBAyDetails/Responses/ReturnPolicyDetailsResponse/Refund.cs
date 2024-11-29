using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "Refund")]
    public class Refund
    {

        [XmlElement(ElementName = "RefundOption")]
        public string RefundOption { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
    }
}
