using GeometricShapes.Domain;
using Xunit;

namespace GeometricShapes.XUnitTest
{
    public class SquarePegUnitTest
    {
        [Fact(DisplayName = "Should SquarePeg create new instance")]
        public void SquarePeg_Case_NewInstance()
        {
            int width = 6;

            var squarePeg = new SquarePeg(width);

            Assert.Equal(width, squarePeg.Width);
        }

        [Fact(DisplayName = "Should GetSquare return Square")]
        public void Squarepeg_Case_GetSquare()
        {   
            int result = 16;
            int with = 4;
            var squarePeg = new SquarePeg(with);

            double square = squarePeg.GetSquare();

            Assert.Equal(result, square);
        }
    }
}
