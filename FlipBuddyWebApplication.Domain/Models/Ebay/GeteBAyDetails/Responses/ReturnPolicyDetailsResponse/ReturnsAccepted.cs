using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "ReturnsAccepted")]
    public class ReturnsAccepted
    {

        [XmlElement(ElementName = "ReturnsAcceptedOption")]
        public string ReturnsAcceptedOption { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
    }
}
