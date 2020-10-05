namespace AutomotiveIndustry.Domain.Builders
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetTripComputer();
        void SetGPS();
        void GetResult();
    }
}