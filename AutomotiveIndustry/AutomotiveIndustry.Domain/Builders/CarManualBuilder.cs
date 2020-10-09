using System;
using AutomotiveIndustry.Domain.Cars;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Builders
{
    public  class CarManualBuilder: IBuilder
    {
        public TypeCar Type { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }
        public Transmission Transmission { get; private set; }
        public double Fuel { get; private set; }


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
    }
}
