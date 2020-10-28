namespace GeometricShapes.Domain
{
    public class RoundHole
    {
        public RoundHole(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public bool Fits(RoundPeg roundPeg)
        {
            return Radius == roundPeg.Radius;
        }
    }
}