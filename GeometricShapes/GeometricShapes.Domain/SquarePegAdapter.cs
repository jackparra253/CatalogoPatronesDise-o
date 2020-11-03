using System;
using GeometricShapes.Domain;

namespace GeometricShapes.XUnitTest
{
    public class SquarePegAdapter
    {
        public SquarePeg SquarePeg { get; private set; }

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            SquarePeg = squarePeg;
        }

        public double GetRadius()
        {
            return Math.Sqrt(Math.Pow(SquarePeg.Width/ 2, 2) * 2);
        }
    }
}