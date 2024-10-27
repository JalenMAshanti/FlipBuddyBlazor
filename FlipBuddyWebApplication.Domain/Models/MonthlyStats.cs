namespace FlipBuddyWebApplication.Domain.Models
{
    public class MonthlyStats
    {
        public string Month { get; set; } = string.Empty;
        public Decimal Sale { get; set; }
        public Decimal Profit { get; set; }
    }
}
