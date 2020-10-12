using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;
using Xunit;

namespace AutomotiveIndustry.Test
{
    public class ManualUnitTest
    {
        [Fact(DisplayName="Should manual new instance return a new Manual")]
        public void Manual_Case_Manual()
        {
            var city = TypeCar.City;
            int seats = 2;
            var engine = new Engine(10, 15);
            var automatic = Transmission.Automatic;
            var gpsNavigator = new GPSNavigator();
            gpsNavigator.AddAutomaticRoute();
            int fuel = 0;

            var manual = new Manual(city, seats, engine,automatic, gpsNavigator);

            Assert.Equal(city, manual.TypeCar);
            Assert.Equal(seats, manual.Seats);
            Assert.Equal(automatic, manual.Transmission);
            Assert.Equal(gpsNavigator.Route, manual.GPSNavigator.Route);
            Assert.Equal(fuel, manual.Fuel);
        }

        [Fact(DisplayName = "should print return string with detail Manual")]
        public void Manual_Case_Print()
        {
            var city = TypeCar.City;
            int seats = 2;
            var engine = new Engine(10, 15);
            var automatic = Transmission.Automatic;
            var gpsNavigator = new GPSNavigator();
            var detail = $"Type of car: {city}, Count of seats: {seats}, Engine: volume - {engine.Volume}, mileage - ${engine.Mileage}, GPS Navigator: ${ gpsNavigator.Route }";
            var manual = new Manual(city, seats, engine, automatic, gpsNavigator);

            string detailManual = manual.Print();
            
            Assert.Equal(detail, detailManual);
        }
    }
}
