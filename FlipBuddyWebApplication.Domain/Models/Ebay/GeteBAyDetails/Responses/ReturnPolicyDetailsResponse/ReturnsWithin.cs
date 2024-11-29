using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "ReturnsWithin")]
    public class ReturnsWithin
    {

        [XmlElement(ElementName = "ReturnsWithinOption")]
        public string ReturnsWithinOption { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
    }
}
