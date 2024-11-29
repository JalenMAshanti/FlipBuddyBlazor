using System.Text.Json.Serialization;

namespace FlipBuddyWebApplication.Domain.Models
{
	public class Specific
	{
		public string SpecificName { get; set; } = string.Empty;
		public List<SpecificValue> SpecificValues { get; set; } = new List<SpecificValue>();
		public bool IsRequired { get; set; } = false;
	}

	public class SpecificValue
	{
		[JsonPropertyName("specificValue")]
		public string Value { get; set; } = string.Empty;
		public List<string> ValueOptions { get; set; } = new List<string>();
	}

}
