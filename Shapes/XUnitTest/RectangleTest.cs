using System.Drawing;
using Xunit;

namespace XUnitTest
{
    public class RectangleTest
    {
        [Fact(DisplayName = "Should Rectangle GetWith")]
        public void Rectangle_Case_GetWidth()
        {
            int x = 2;
            int y = 3;
            int width = 2;
            int height = 3;
            Color color = new Color();

            Domain.Rectangle rectangle = new Domain.Rectangle(x, y, width, height, color);

            Assert.Equal(width, rectangle.GetWidth());
        }

        [Fact(DisplayName = "Should Rectangle GetHeight")]
        public void Rectangle_Case_GetHeight()
        {
            int x = 2;
            int y = 3;
            int width = 2;
            int height = 3;
            Color color = new Color();

            Domain.Rectangle rectangle = new Domain.Rectangle(x, y, width, height, color);

            Assert.Equal(height, rectangle.GetHeight());
        }

    }
}
