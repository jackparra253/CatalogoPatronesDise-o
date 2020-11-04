using System;
using GeometricShapes.XUnitTest;

namespace GeometricShapes.Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Round fits round, no surprise.
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            if (hole.Fits(rpeg))
            {
                Console.WriteLine("Round peg r5 fits round hole r5.");
            }

            var smallSqPeg = new SquarePeg(2);
            var largeSqPeg = new SquarePeg(20);
            // hole.fits(smallSqPeg); // Won't compile.

            // Adapter solves the problem.
            var smallSqPegAdapter = new SquarePegAdapter(smallSqPeg);
            var largeSqPegAdapter = new SquarePegAdapter(largeSqPeg);
            if (hole.Fits(smallSqPegAdapter))
            {
                Console.WriteLine("Square peg w2 fits round hole r5.");
            }
            if (hole.Fits(largeSqPegAdapter) is false)
            {
                Console.WriteLine("Square peg w20 does not fit into round hole r5.");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
