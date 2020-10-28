namespace GeometricShapes.Domain
{
    public class RoundPeg
    {
        public RoundPeg(in double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }
    }
}