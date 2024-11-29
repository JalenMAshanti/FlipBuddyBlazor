using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ShippingServiceDetailsResponse
{
    [XmlRoot(ElementName = "ShippingServicePackageDetails")]
    public class ShippingServicePackageDetails
    {

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "DimensionsRequired")]
        public bool DimensionsRequired { get; set; }
    }
}
