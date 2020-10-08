namespace AutomotiveIndustry.Domain.Components
{
    public class GPSNavigator
    {
        public string Route { get; private set; }

        public void AddAutomaticRoute()
        {
            Route = "Golden Museum, cra 6 # 15-18, Bogotá Cundinamarca";
        }

        public void AddManualRoute(string route)
        {
            Route = route;
        }
    }
}
