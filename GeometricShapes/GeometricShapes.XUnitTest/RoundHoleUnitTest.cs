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


        [Fact(DisplayName = "Should Fits return value if or not to Round Hole")]
        public void RoundHole_Case_Fits()
        {
            double radius = 4;
            var roundPeg = new RoundPeg(radius);
            var roundHole = new RoundHole(radius);

            bool fit = roundHole.Fits(roundPeg);

            Assert.True(fit);
        }
    }
}
