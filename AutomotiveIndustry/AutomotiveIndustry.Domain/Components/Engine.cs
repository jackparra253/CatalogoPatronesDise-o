using System;

namespace AutomotiveIndustry.Domain.Components
{
    public class Engine
    {
        public double Volume { get; private set; }
        public double Mileage { get; private set; }
        public bool Started { get; private set; }

        public Engine(double volume, double mileage)
        {
            Volume = volume;
            Mileage = mileage;
            Started = false;
        }

        public void On()
        {
            Started = true;
        }

        public void Off()
        {
            Started = false;
        }

        public bool IsStarted()
        {
            return Started;
        }

        public void Go(double mileage)
        {
            if (Started)
                Mileage += mileage;
            else
                throw new Exception("Cannot go(), you must start engine first!");
        }
    }
}