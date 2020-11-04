namespace GeometricShapes.Domain
{
    public class RoundPeg
    {
        public RoundPeg(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }
    }
}