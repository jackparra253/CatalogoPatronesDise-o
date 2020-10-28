using GeometricShapes.Domain;
using Xunit;

namespace GeometricShapes.XUnitTest
{
    public class RoundPegUnitTest
    {
        [Fact(DisplayName = "Should RoundPeg return new instance")]
        public void RoundPeg_Case_NewInstance()
        {
            double radius = 6;

            var roundPeg = new RoundPeg(radius);

            Assert.Equal(radius, roundPeg.Radius);
        }
    }
}
