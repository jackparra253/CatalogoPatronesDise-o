using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Builders
{
    public interface IBuilder
    {

        void SetType(TypeCar typeCar);
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}