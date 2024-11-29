using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Request
{
    [XmlRoot(ElementName = "GeteBayDetailsRequest")]
    public class GeteBayDetailsRequest
    {

        [XmlElement(ElementName = "ErrorLanguage")]
        public string ErrorLanguage { get; set; } = "en_US";

        [XmlElement(ElementName = "WarningLevel")] 
        public string WarningLevel { get; set; } = "High";

        [XmlElement(ElementName = "DetailName")]
        public string DetailName { get; set; } = "ShippingServiceDetails";

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
