using Xunit;

namespace AutomotiveIndustry.Test
{
    public class EngineUniTest
    {
        [Fact(DisplayName = "should Engine return Volume and mileage.")]
        public void Engine_Case_VolumeMileage()
        {
            const double volume = 1.5;
            const double mileage = 2.5;

            var engine = new Engine(volume, mileage);

            Assert.Equal(volume, engine.Volume);
            Assert.Equal(mileage, engine.Mileage);
        }
    }

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
