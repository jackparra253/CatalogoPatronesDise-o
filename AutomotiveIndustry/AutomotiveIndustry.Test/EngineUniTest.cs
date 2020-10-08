using AutomotiveIndustry.Domain.Components;
using System;
using Xunit;

namespace AutomotiveIndustry.Test
{
    public class EngineUniTest
    {
        [Fact(DisplayName = "should Engine return Volume, mileage and started on false.")]
        public void Engine_Case_VolumeMileage()
        {
            const double volume = 1.5;
            const double mileage = 2.5;

            var engine = new Engine(volume, mileage);

            Assert.Equal(volume, engine.Volume);
            Assert.Equal(mileage, engine.Mileage);
            Assert.False(engine.Started);
        }

        [Fact(DisplayName = "should On set started in true")]
        public void Engine_Case_On()
        {
            const double volume = 1.5;
            const double mileage = 2.5;
            var engine = new Engine(volume, mileage);

            engine.On();

            Assert.True(engine.Started);
        }

        [Fact(DisplayName = "should Off set started in false")]
        public void Engine_Case_Off()
        {
            const double volume = 1.5;
            const double mileage = 2.5;
            var engine = new Engine(volume, mileage);

            engine.Off();

            Assert.False(engine.Started);
        }

        [Fact(DisplayName = "should IsStarted return value")]
        public void Engine_Case_IsStarted()
        {
            const double volume = 1.5;
            const double mileage = 2.5;
            var engine = new Engine(volume, mileage);
            engine.Off();

            bool isStarted = engine.IsStarted();

            Assert.False(isStarted);
        }

        [Fact(DisplayName = "should Go add milage when started is true")]
        public void Engine_Case_Go_Started_True()
        {
            const double volume = 1.5;
            const double mileage = 2.5;
            const double newMileage = 2.5;
            const double totalMilage = 5;
            var engine = new Engine(volume, mileage);
            engine.On();

            engine.Go(newMileage);

            Assert.Equal(totalMilage, engine.Mileage);
        }

        [Fact(DisplayName = "should Go Exception when started is false")]
        public void Engine_Case_Go_Started_False()
        {
            const double volume = 1.5;
            const double mileage = 2.5;
            const double newMileage = 2.5;
            var engine = new Engine(volume, mileage);

            string errorMessage = Assert.Throws<Exception>(() => engine.Go(newMileage)).Message;
            
            Assert.Equal("Cannot go(), you must start engine first!", errorMessage);
        }
    }
}