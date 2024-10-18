using FlipBuddyWebApplication.Domain.Models;

namespace FlipBuddyWebApplication.Client.ViewModels.Home.DonutChart
{
    public class DonutChartViewModel
    {
        public int TotalProductsListed { get; set; }
        public double[]? GraphData {  get; set; }
    }
}
