using Appwrite.Enums;
using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Persistence.API.ApiResponses.ConditionResponses
{

	public class ConditionInfo
	{
		public int conditionId { get; set; }
		public string conditionTitle { get; set; } = string.Empty;
		public string description { get; set; } = string.Empty;

		public Condition AsDomainCondition() => new (conditionId, conditionTitle, description);
	}

	public class GetAllConditionsResponse
	{
		public List<ConditionInfo>? conditions { get; set; }
	}


}
