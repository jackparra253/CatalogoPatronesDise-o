using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Cars
{
    public class Car
    {
        public TypeCar TypeCar { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public GPSNavigator GPSNavigator { get; private set; }
        public double Fuel { get; private set; }

        public Car(TypeCar typeCar, int seats, Engine engine, Transmission transmission,
            GPSNavigator gpsNavigator)
        {
            TypeCar = typeCar;
            Seats = seats;
            Engine = engine;
            Transmission = transmission;
            GPSNavigator = gpsNavigator;
            Fuel = 0;
        }
    }
}
