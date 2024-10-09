using System.ComponentModel.DataAnnotations;

namespace FlipBuddyWebApplication.Domain.Models
{
	public class SignupRequest
	{
		public Guid Guid { get; set; } = Guid.NewGuid();
		[Required]
		public string Username { get; set; } = string.Empty;
		[Required]
		public string FirstName { get; set; } = string.Empty;
		[Required]
		public string LastName { get; set; } = string.Empty;
		[Required]
		public string Password { get; set; } = string.Empty;
		[Required]
		public string Email { get; set; } = string.Empty;
	}
}
