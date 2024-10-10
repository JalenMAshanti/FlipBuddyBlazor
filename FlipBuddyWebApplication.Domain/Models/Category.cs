namespace FlipBuddyWebApplication.Domain.Models
{
    public class Category
    {
        public Category(int categoryId,
                        string name,
                        string bio,
                        int productCount) 
        {
            CategoryId = categoryId;
            Name = name;
            Bio = bio;
            ProductCount = productCount;
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public int ProductCount { get; set; }
    }
}
