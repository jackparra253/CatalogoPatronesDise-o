using Domain;
using System.Drawing;
using Xunit;

namespace XUnitTest
{
    public class BaseShapeTest
    {
        [Fact(DisplayName = "should return new instance")]
        public void BaseShape_New_Object()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);

            Assert.Equal(x, baseShape.X);
            Assert.Equal(y, baseShape.Y);
            Assert.False(baseShape.Selected);
        }

        [Fact(DisplayName = "Should Getx return x value")]
        public void BaseShape_Getx_ReturnX()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);

            Assert.Equal(x, baseShape.GetX());
        }

        [Fact(DisplayName = "Should Getx return y value")]
        public void BaseShape_Gety_ReturnY()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);

            Assert.Equal(y, baseShape.GetY());
        }

        [Fact(DisplayName = "Should GetWidth return 0")]
        public void BaseShape_GetWidth_Width()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);

            Assert.Equal(0, baseShape.GetWidth());
        }

        [Fact(DisplayName = "Should GetHeight return 0")]
        public void BaseShape_GetHeight_ReturnHeight()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);

            Assert.Equal(0, baseShape.GetHeight());
        }

        [Fact(DisplayName = "Should Select set Selected in true")] 
        public void BaseShape_Select_SelectedTrue()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new BaseShape(x, y, color);
            baseShape.Select();

            Assert.True(baseShape.IsSelected());
        }
    }
}
