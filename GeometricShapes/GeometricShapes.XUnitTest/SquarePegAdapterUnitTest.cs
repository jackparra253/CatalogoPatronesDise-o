using GeometricShapes.Domain;
using Xunit;

namespace GeometricShapes.XUnitTest
{
    public class SquarePegAdapterUnitTest
    {
        [Fact(DisplayName = "Should GetRadius return radius value")]
        public void SquarePegAdapter_Case_GetRadius()
        {
            var squarePeg = new SquarePeg(9);
            var squarePegAdapter = new SquarePegAdapter(squarePeg);

            var radius = squarePegAdapter.GetRadius();

            Assert.Equal(5.656854249492381, radius);
        }

    }
}
