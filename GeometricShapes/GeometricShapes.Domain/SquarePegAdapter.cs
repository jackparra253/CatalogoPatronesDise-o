using System;
using GeometricShapes.Domain;

namespace GeometricShapes.XUnitTest
{
    public class SquarePegAdapter: RoundPeg
    {
        public SquarePeg SquarePeg { get; private set; }

        public double Radius { get; private set; }

        public SquarePegAdapter(SquarePeg squarePeg) : base(squarePeg.GetSquare())
        {
            SquarePeg = squarePeg;
        }

        public double GetRadius()
        {
            Radius = Math.Sqrt(Math.Pow(SquarePeg.Width / 2, 2) * 2);

            return Radius;
        }
    }
}