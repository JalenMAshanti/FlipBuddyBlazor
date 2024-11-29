using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.ShippingServiceDetailsResponse
{
    [XmlRoot(ElementName = "ShippingServiceDetails")]
    public class ShippingServiceDetails
    {

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "InternationalService")]
        public bool InternationalService { get; set; }

        [XmlElement(ElementName = "ShippingService")]
        public string ShippingService { get; set; }

        [XmlElement(ElementName = "ShippingServiceID")]
        public int ShippingServiceID { get; set; }

        [XmlElement(ElementName = "ShippingTimeMax")]
        public int ShippingTimeMax { get; set; }

        [XmlElement(ElementName = "ShippingTimeMin")]
        public int ShippingTimeMin { get; set; }

        [XmlElement(ElementName = "ServiceType")]
        public List<string> ServiceType { get; set; }

        [XmlElement(ElementName = "ShippingPackage")]
        public List<string> ShippingPackage { get; set; }

        [XmlElement(ElementName = "ValidForSellingFlow")]
        public bool ValidForSellingFlow { get; set; }

        [XmlElement(ElementName = "ShippingServicePackageDetails")]
        public List<ShippingServicePackageDetails> ShippingServicePackageDetails { get; set; }

        [XmlElement(ElementName = "DetailVersion")]
        public int DetailVersion { get; set; }

        [XmlElement(ElementName = "UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [XmlElement(ElementName = "ShippingCategory")]
        public string ShippingCategory { get; set; }

        [XmlElement(ElementName = "ShippingCarrier")]
        public string ShippingCarrier { get; set; }

        [XmlElement(ElementName = "WeightRequired")]
        public bool WeightRequired { get; set; }

        [XmlElement(ElementName = "DimensionsRequired")]
        public bool DimensionsRequired { get; set; }

        [XmlElement(ElementName = "SurchargeApplicable")]
        public bool SurchargeApplicable { get; set; }

        [XmlElement(ElementName = "ExpeditedService")]
        public bool ExpeditedService { get; set; }

        [XmlElement(ElementName = "DeprecationDetails")]
        public DeprecationDetails DeprecationDetails { get; set; }

        [XmlElement(ElementName = "MappedToShippingServiceID")]
        public int MappedToShippingServiceID { get; set; }
    }
}
