using System;
using AutomotiveIndustry.Domain.Components;

namespace AutomotiveIndustry.Domain.Builders
{
    public interface IBuilder
    {

        void SetType(Type type);
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}