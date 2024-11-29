using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.GetCategories.Response
{
	[XmlRoot(ElementName = "CategoryArray")]
	public class CategoryArray
	{

		[XmlElement(ElementName = "Category")]
		public List<EbayCategory> Category { get; set; }
	}
}
