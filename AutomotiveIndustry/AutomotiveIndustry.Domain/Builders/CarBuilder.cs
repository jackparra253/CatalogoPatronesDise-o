using System;
using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Builders
{
    public class CarBuilder : IBuilder
    {
        private TypeCar type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private GPSNavigator gpsNavigator;

        public void SetType(Type type)
        {
            throw new NotImplementedException();
        }

        public void SetSeats(int seats)
        {
            throw new NotImplementedException();
        }

        public void SetEngine(Engine engine)
        {
            throw new NotImplementedException();
        }

        public void SetTransmission(Transmission transmission)
        {
            throw new NotImplementedException();
        }

        public void SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            throw new NotImplementedException();
        }

        public Car GetResult()
        {
            return new Car(type, seats, engine, transmission, gpsNavigator);
        }
    }
}