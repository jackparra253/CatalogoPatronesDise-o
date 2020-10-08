using AutomotiveIndustry.Domain.Components;
using Xunit;

namespace AutomotiveIndustry.Test
{
    public class GPSNavigatorUnitTest
    {
        [Fact(DisplayName = "Should AddAutomaticRoute Route when is default value")]
        public void AddAutomaticRoute_Case_DefaultRoute()
        {
            var defaultRoute = "Golden Museum, cra 6 # 15-18, Bogotá Cundinamarca";

            var gpsNavigator = new GPSNavigator();
            gpsNavigator.AddAutomaticRoute();

            Assert.Equal(defaultRoute, gpsNavigator.Route);
        }

        [Fact(DisplayName = "Should AddManualRoute set new Route")]
        public void AddManualRoute_Case_CustomRoute()
        {
            var customRoute = "Cll 49 # 24-46";

            var gpsNavigator = new GPSNavigator();
            gpsNavigator.AddManualRoute(customRoute);

            Assert.Equal(customRoute, gpsNavigator.Route);
        }
    }
}
