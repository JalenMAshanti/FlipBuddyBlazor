namespace FlipBuddyWebApplication.Domain.Models
{
    public class Product
    {
        public Product(string productGuid,
                        string title,
                        int categoryId,
                        decimal puchasePrice,
                        decimal sellPrice,
                        string description,
                        int quantity,
                        string currency,
                        int conditionId,
                        string barcode,
                        string dateSold)
        {
            ProductGuid = productGuid;
            Title = title;
            CategoryId = categoryId;
            PurchasePrice = puchasePrice;
            SellPrice = sellPrice;
            Description = description;
            Quantity = quantity;
            Currency = currency;
            ConditionId = conditionId;
            Barcode = barcode;
            DateSold = dateSold;
        }

        public string ProductGuid { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Currency { get; set; } = string.Empty;
        public int ConditionId { get; set; }
        public string Barcode { get; set; }
        public string DateSold { get; set; }

        public decimal CalculateProfit() 
        {
            var profit = SellPrice - PurchasePrice;
            return profit;
        }
    }
}
