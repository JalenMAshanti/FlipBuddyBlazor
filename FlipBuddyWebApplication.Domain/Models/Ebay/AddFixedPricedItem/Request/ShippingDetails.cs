using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "ShippingDetails")]
    public class ShippingDetails
    {

        [XmlElement(ElementName = "ShippingType")]
        public string ShippingType { get; set; } = "Flat";

        [XmlElement(ElementName = "ShippingServiceOptions")]
        public ShippingServiceOptions? ShippingServiceOptions { get; set; }
    }
}
