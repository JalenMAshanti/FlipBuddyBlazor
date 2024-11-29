using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "ItemSpecifics")]
    public class ItemSpecifics
    {

        [XmlElement(ElementName = "NameValueList")]
        public List<NameValueList>? NameValueList { get; set; }
    }
}
