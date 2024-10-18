namespace FlipBuddyWebApplication.Domain.Models
{
    public class InsertProductByImageRequest
    {
        public string Image { get; set; } = string.Empty;
        public Guid Guid { get; set; }
        public Guid UserGuid { get; set; }       
    }
}
