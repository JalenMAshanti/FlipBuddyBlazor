using Appwrite;
using Appwrite.Services;

namespace FlipBuddyWebApplication.Persistence.Repositories
{

	public class GoogleAuthService
	{
		private readonly Client _client;
		public readonly Account _account;

		public GoogleAuthService()
		{
			_client = new Client()
				.SetEndpoint("https://cloud.appwrite.io/v1") // Appwrite Endpoint
				.SetProject("6709c6890001e7ecf89b");                   // Project ID

			_account = new Account(_client);
		}
	}
}
