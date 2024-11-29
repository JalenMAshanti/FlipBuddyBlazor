using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{

    [XmlRoot(ElementName = "PrimaryCategory")]
    public class PrimaryCategory
    {

        [XmlElement(ElementName = "CategoryID")]
        public int CategoryID { get; set; }
    }
}
