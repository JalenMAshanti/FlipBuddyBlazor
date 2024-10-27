using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.UserResponses
{

    public class GetUserByGuidResponse
    {
        public UserResponse user { get; set; } = new UserResponse();

        public User AsDomainUser() => new(user.username, user.firstName, user.lastName, user.password, user.email, user.subscriptionTier, user.flips);
    }

    public class UserResponse
    {
        public string guid { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string passwordHash { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public int subscriptionTier { get; set; }
        public int flips { get; set; }

    }
}
