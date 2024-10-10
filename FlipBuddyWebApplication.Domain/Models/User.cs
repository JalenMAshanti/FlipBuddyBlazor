namespace FlipBuddyWebApplication.Domain.Models
{
	public class User
	{
		public User(string username,
					string firstName,
					string lastName,
					string password,
					string email,
					int subscriptionTier) 
		{
			Username = username;
			FirstName = firstName;
			LastName = lastName;
			Password = password;
			Email = email;
			SubscriptionTier = subscriptionTier;
		}	

		public string Username { get; set; } = string.Empty;
		public string FirstName {  get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public int SubscriptionTier { get; set; }
	}
}
