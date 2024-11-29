using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "PictureDetails")]
    public class PictureDetails
    {

        [XmlElement(ElementName = "PictureURL")]
        public string? PictureURL { get; set; }
    }
}
