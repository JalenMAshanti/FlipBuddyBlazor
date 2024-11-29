namespace FlipBuddyWebApplication.Domain.Models.Ebay.EbayToken.Responses.Token
{
    public class TokenResponse
    {
        public string? access_token { get; set; }
        public string? token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public int refresh_token_expires_in { get; set; }
    }
}
