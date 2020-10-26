using System;

namespace GeometricShapes.Domain
{
    public class SquarePeg
    {
        public SquarePeg(int width)
        {
            Width = width;
        }

        public int Width { get; private set; }

        public double GetSquare()
        {
            return Math.Pow(Width, 2);
        }
    }
}