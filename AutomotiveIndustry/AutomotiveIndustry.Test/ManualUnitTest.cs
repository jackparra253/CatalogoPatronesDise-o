using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;
using Xunit;

namespace AutomotiveIndustry.Test
{
    public class ManualUnitTest
    {
        [Fact(DisplayName="Should manual new instance return a new Car")]
        public void Manual_Case_Manual()
        {
            var sport = TypeCar.Sport;
            int seats = 2;
            var engine = new Engine(10, 15);
            var automatic = Transmission.Automatic;
            var gpsNavigator = new GPSNavigator();
            int fuel = 0;

            var car = new Manual(sport, seats, engine,automatic, gpsNavigator);

            Assert.Equal(sport, car.TypeCar);
            Assert.Equal(seats, car.Seats);
            Assert.Equal(automatic, car.Transmission);
            Assert.Equal(fuel, car.Fuel);
        }
    }
}
