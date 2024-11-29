namespace FlipBuddyWebApplication.Domain.Models.Ebay.ListingOptionsModel
{
    public class EbayListingOptions
    {
        //Base
        public ProductAndSpecifics ProductandSpecifics { get; set; }

        //Return Settings
        public string ReturnsAccepted { get; set; } = "ReturnsAccepted";
        public string ReturnsWithin { get; set; } = "Days_30";
        public string ReturnShippingCostPaidBy { get; set; } = "Buyer";


        //Shipping Settings  
        public bool FreeShipping { get; set; } = true;  
        public int ShippingServicePriority { get; set; } = 1;
        public string ShippingService { get; set; } = "UPSGround"; 
        public double AdditionalShippingCosts { get; set; }

        //Token
        public string Token { get; set; }
    }
}
