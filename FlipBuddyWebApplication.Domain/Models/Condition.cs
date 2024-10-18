namespace FlipBuddyWebApplication.Domain.Models
{
	public class Condition
	{
		public Condition(int conditionId,
						string conditionTitle,
						string description) 
		{
			ConditionId = conditionId;
			ConditionTitle = conditionTitle;
			Description = description;
		}

		public int ConditionId { get; set; }
		public string ConditionTitle { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}

}
