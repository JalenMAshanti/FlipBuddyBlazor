using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "ShippingServiceAdditionalCost")]
    public class ShippingServiceAdditionalCost
    {

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; } = string.Empty;

        [XmlText]
        public double Text { get; set; }
    }
}
