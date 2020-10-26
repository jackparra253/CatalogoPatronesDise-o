using GeometricShapes.Domain;
using Xunit;

namespace GeometricShapes.XUnitTest
{
    public class RoundHoleUnitTest
    {
        [Fact(DisplayName = "Should RoundHole create new instance")]
        public void RoundHole_Case_New_RoundHole()
        {
            double radius = 3;

            var roundHole = new RoundHole(radius);

            Assert.Equal(radius, roundHole.Radius);
        }


        [Fact(DisplayName = "")]
        public void xxxxx()
        {

        }


    }
}
