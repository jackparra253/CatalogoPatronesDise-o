using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;
using Xunit;

namespace AutomotiveIndustry.Test
{
    public class CarUnitTest
    {
        [Fact(DisplayName="Should Car new instance return a new Car")]
        public void Car_Case_SportCar()
        {
            var sport = TypeCar.Sport;
            int seats = 2;
            var engine = new Engine(10, 15);
            var automatic = Transmission.Automatic;
            var gpsNavigator = new GPSNavigator();
            gpsNavigator.AddAutomaticRoute();
            int fuel = 0;

            var car = new Car(sport, seats, engine,automatic, gpsNavigator);

            Assert.Equal(sport, car.TypeCar);
            Assert.Equal(seats, car.Seats);
            Assert.Equal(automatic, car.Transmission);
            Assert.Equal(gpsNavigator.Route, car.GPSNavigator.Route);
            Assert.Equal(fuel, car.Fuel);
        }
    }
}
