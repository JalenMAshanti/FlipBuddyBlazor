namespace FlipBuddyWebApplication.Domain.Helpers
{
    public static class DateConverters
    {
        public static DateOnly ConvertStringToDateOnly(string dateString)
        {
            var withTime = DateTime.Parse(dateString);
            return DateOnly.FromDateTime(withTime);
        }

        public static string ConvertDateOnlyToString(DateOnly dateOnly)
        {
            return dateOnly.ToString("yyyy-M-d");
        }
    }
}
