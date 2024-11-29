using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "NameValueList")]
    public class NameValueList
    {

        [XmlElement(ElementName = "Value")]
        public List<string>? Value { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;
    }
}
