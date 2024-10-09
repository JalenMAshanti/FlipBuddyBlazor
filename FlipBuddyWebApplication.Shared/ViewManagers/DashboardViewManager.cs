namespace FlipBuddyWebApplication.Shared.ViewManagers
{
    public class DashboardViewManager
    {
        
        public DashboardViewManager() 
        {

        }

        public List<string> DashboardComponents { get; set; }
        public string CurrentView { get; set; } = "HomeView";
    }
}
