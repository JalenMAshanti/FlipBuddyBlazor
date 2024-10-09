namespace FlipBuddyWebApplication.Persistence.API.ApiResponses
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
	public class LoginAPIResponse
	{
		public UserGuid? userGuid { get; set; }
	}

	public class UserGuid
	{
		public string? guid { get; set; }
	}
}
