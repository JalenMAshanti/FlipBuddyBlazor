namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.LoginResponses
{
    public class LoginAPIResponse
    {
        public UserGuid userGuid { get; set; } = new UserGuid();
    }

    public class UserGuid
    {
        public string guid { get; set; } = string.Empty;
    }
}
