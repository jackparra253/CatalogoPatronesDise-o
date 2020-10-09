using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Cars
{
    public class Car
    {
        public TypeCar Type { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public double Fuel { get; private set; }

        public Car(TypeCar type, int seats, Engine engine, Transmission transmission,
            GPSNavigator gpsNavigator)
        {
            Type = type;
            Seats = seats;
            Engine = engine;
            Transmission = transmission;
            Fuel = 0;
        }
    }
}
