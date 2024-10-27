using System.Globalization;

namespace FlipBuddyWebApplication.Domain.Helpers
{
    public class MonthHelper
    {
        public static List<(int Month, int Year, string MonthName)> GetLastEightMonthsWithYear()
        {
            List<(int Month, int Year, string MonthName)> months = new List<(int, int, string)>();
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // Loop through the last 8 months, including the current month
            for (int i = 7; i >= 0; i--)
            {
                // Calculate the month and year
                int month = (currentMonth - i + 11) % 12 + 1;
                int year = currentYear - (currentMonth - i <= 0 ? 1 : 0);

                // Get the abbreviated name of the month
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(month);

                months.Add((month, year, monthName));
            }

            return months;
        }
    }
}
