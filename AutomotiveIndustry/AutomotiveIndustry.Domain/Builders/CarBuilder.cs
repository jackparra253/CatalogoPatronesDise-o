using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Builders
{
    public class CarBuilder : IBuilder
    {
        public TypeCar TypeCar { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public GPSNavigator GPSNavigator { get; private set; }

        public void SetType(TypeCar typeCar)
        {
            TypeCar = typeCar;
        }

        public void SetSeats(int seats)
        {
            Seats = seats;
        }

        public void SetEngine(Engine engine)
        {
            Engine = engine;
        }

        public void SetTransmission(Transmission transmission)
        {
            Transmission = transmission;
        }

        public void SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            GPSNavigator = gpsNavigator;
        }

        public Car GetResult()
        {
            return new Car(TypeCar, Seats, Engine, Transmission, GPSNavigator);
        }
    }
}