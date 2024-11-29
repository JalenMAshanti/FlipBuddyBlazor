using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ShippingServiceDetailsResponse
{
    [XmlRoot(ElementName = "DeprecationDetails")]
    public class DeprecationDetails
    {

        [XmlElement(ElementName = "AnnouncementStartTime")]
        public DateTime AnnouncementStartTime { get; set; }

        [XmlElement(ElementName = "EventTime")]
        public DateTime EventTime { get; set; }

        [XmlElement(ElementName = "MessageType")]
        public string MessageType { get; set; }
    }
}
