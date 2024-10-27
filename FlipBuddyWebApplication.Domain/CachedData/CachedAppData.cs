using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Domain.CachedData
{
    public static class CachedAppData
    {
        // used for data that doesnt need to keep making calls to api

        public static List<Category>? AllCategoies { get; set; } = new List<Category>();

        public static List<Condition>? AllConditions { get; set; } = new List<Condition>();
    }
}
