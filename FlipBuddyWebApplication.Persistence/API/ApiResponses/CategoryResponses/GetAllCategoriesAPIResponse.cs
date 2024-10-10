using FlipBuddyWebApplication.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.CategoryResponses
{

    public class CategoryInfo
    {
        public int categoryId { get; set; }
        public string name { get; set; } = string.Empty;
        public string bio { get; set; } = string.Empty;
        public int productCount {  get; set; }
        public Category AsDomainCategory() => new Category(categoryId, name, bio, productCount);
    }

    public class GetAllCategoriesAPIResponse
    {
        public List<CategoryInfo>? categories { get; set; }

    }

}
