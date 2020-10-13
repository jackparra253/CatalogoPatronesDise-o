using AutomotiveIndustry.Domain.Builders;
using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain
{
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.SetType(TypeCar.Sport);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(3.0, 0));
            builder.SetTransmission(Transmission.SemiAutomatic);
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ConstructCityCar(IBuilder builder)
        {
            builder.SetType(TypeCar.City);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(1.2, 0));
            builder.SetTransmission(Transmission.Automatic);
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.SetType(TypeCar.Suv);
            builder.SetSeats(4);
            builder.SetEngine(new Engine(2.5, 0));
            builder.SetTransmission(Transmission.Manual);
            builder.SetGPSNavigator(new GPSNavigator());
        }
    }
}
