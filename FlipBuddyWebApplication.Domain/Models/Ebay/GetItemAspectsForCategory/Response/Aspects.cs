namespace FlipBuddyWebApplication.Domain.Models.Ebay.GetItemAspectsForCategory.Response
{
	public class Aspect
	{
		public string localizedAspectName { get; set; }
		public AspectConstraint aspectConstraint { get; set; }
		public List<AspectValue> aspectValues { get; set; }
	}

	public class AspectConstraint
	{
		public string aspectDataType { get; set; }
		public string itemToAspectCardinality { get; set; }
		public string aspectMode { get; set; }
		public bool aspectRequired { get; set; }
		public string aspectUsage { get; set; }
		public bool aspectEnabledForVariations { get; set; }
		public List<string> aspectApplicableTo { get; set; }
		public int? aspectMaxLength { get; set; }
	}

	public class AspectValue
	{
		public string localizedValue { get; set; }
	}

	public class Aspects
	{
		public List<Aspect> aspects { get; set; }
	}
}
