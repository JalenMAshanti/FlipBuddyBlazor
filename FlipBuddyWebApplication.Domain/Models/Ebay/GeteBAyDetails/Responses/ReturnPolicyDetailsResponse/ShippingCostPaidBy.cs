using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "ShippingCostPaidBy")]
    public class ShippingCostPaidBy
    {

        [XmlElement(ElementName = "ShippingCostPaidByOption")]
        public string ShippingCostPaidByOption { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
    }
}
