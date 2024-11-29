using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "ReturnPolicyDetails")]
    public class ReturnPolicyDetails
    {

        [XmlElement(ElementName = "Refund")]
        public List<Refund> Refund { get; set; }

        [XmlElement(ElementName = "ReturnsWithin")]
        public List<ReturnsWithin> ReturnsWithin { get; set; }

        [XmlElement(ElementName = "ReturnsAccepted")]
        public List<ReturnsAccepted> ReturnsAccepted { get; set; }

        [XmlElement(ElementName = "Description")]
        public bool Description { get; set; }

        [XmlElement(ElementName = "ShippingCostPaidBy")]
        public List<ShippingCostPaidBy> ShippingCostPaidBy { get; set; }

        [XmlElement(ElementName = "RestockingFeeValue")]
        public List<RestockingFeeValue> RestockingFeeValue { get; set; }

        [XmlElement(ElementName = "DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime UpdateTime { get; set; }
    }
}
