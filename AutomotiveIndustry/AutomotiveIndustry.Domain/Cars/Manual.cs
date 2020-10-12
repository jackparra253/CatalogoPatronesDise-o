using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Cars
{
    public class Manual
    {
        public TypeCar TypeCar { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public double Fuel { get; private set; }
        public GPSNavigator GPSNavigator { get; private set; }

        public Manual(TypeCar typeCar, int seats, Engine engine, Transmission transmission,
            GPSNavigator gpsNavigator)
        {
            TypeCar = typeCar;
            Seats = seats;
            Engine = engine;
            Transmission = transmission;
            GPSNavigator = gpsNavigator;
            Fuel = 0;
        }

        public string Print()
        {
            return $"Type of car: {TypeCar}, Count of seats: {Seats}, Engine: volume - {Engine.Volume}, mileage - ${Engine.Mileage}, GPS Navigator: ${ GPSNavigator.Route }";
        }
    }
}
