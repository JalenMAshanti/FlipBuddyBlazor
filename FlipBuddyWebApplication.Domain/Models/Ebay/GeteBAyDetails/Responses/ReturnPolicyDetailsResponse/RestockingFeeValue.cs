using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ReturnPolicyDetailsResponse
{
    [XmlRoot(ElementName = "RestockingFeeValue")]
    public class RestockingFeeValue
    {

        [XmlElement(ElementName = "RestockingFeeValueOption")]
        public string RestockingFeeValueOption { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
    }
}
