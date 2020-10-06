namespace AutomotiveIndustry.Domain.Components
{
    public class Engine
    {
        public double Volume { get; private set; }
        public double Mileage { get; private set; }

        public Engine(double volume, double mileage)
        {
            Volume = volume;
            Mileage = mileage;
        }
    }
}