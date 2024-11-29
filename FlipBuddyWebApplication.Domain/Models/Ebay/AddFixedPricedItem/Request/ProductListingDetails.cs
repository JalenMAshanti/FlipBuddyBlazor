﻿using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request
{
    [XmlRoot(ElementName = "ProductListingDetails")]
    public class ProductListingDetails
    {

        [XmlElement(ElementName = "UPC")]
        public double UPC { get; set; }

        [XmlElement(ElementName = "IncludeStockPhotoURL")]
        public bool IncludeStockPhotoURL { get; set; }

        [XmlElement(ElementName = "IncludeeBayProductDetails")]
        public bool IncludeeBayProductDetails { get; set; }

        [XmlElement(ElementName = "UseFirstProduct")]
        public bool UseFirstProduct { get; set; }

        [XmlElement(ElementName = "ReturnSearchResultOnDuplicates")]
        public bool ReturnSearchResultOnDuplicates { get; set; }
    }
}
