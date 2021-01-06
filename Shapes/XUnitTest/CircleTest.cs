using Domain;
using System.Drawing;
using Xunit;

namespace XUnitTest
{
    public class CircleTest
    {
        [Fact(DisplayName = "Should Circle create new instance")]
        public void Circle_Case_NewObject()
        {
            int x = 1;
            int y = 3;
            Color color = new Color();
            int radius = 4;

            Circle circle = new Circle(x, y, color, radius);

            Assert.Equal(x, circle.X);
            Assert.Equal(y, circle.Y);
            Assert.False(circle.Selected);
            Assert.Equal(radius, circle.Radius);
        }

        [Fact(DisplayName = "Should Getx return x value")]
        public void BaseShape_Getx_ReturnX()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new Circle(x, y, color, 2);

            Assert.Equal(x, baseShape.GetX());
        }

        [Fact(DisplayName = "Should Getx return y value")]
        public void BaseShape_Gety_ReturnY()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            BaseShape baseShape = new Circle(x, y, color, 2);

            Assert.Equal(y, baseShape.GetY());
        }

        [Fact(DisplayName = "Should GetWidth return radius * 2")]
        public void BaseShape_GetWidth_Width()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            Circle circle = new Circle(x, y, color, 2);

            Assert.Equal(4, circle.GetWidth());
        }

        [Fact(DisplayName = "Should GetHeight return radius * 2")]
        public void BaseShape_GetHeight_ReturnHeight()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();

            Circle circle = new Circle(x, y, color, 2);

            Assert.Equal(4, circle.GetHeight());
        }

        [Fact(DisplayName = "Should Select set Selected in true")]
        public void BaseShape_Select_SelectedTrue()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();
            BaseShape baseShape = new Circle(x, y, color, 2);

            baseShape.Select();

            Assert.True(baseShape.IsSelected());
        }

        [Fact(DisplayName = "Should UnSelect set Selected in False")]
        public void BaseShape_UnSelect_Selected()
        {
            int x = 1;
            int y = 1;
            Color color = new Color();
            BaseShape baseShape = new Circle(x, y, color, 2);

            baseShape.UnSelect();

            Assert.False(baseShape.IsSelected());
        }

        [Fact(DisplayName = "should Move sum value for X and Y")]
        public void BaseShapoe_Move_SetXY()
        {
            int x = 3;
            int y = 2;
            Color color = new Color();
            BaseShape baseShape = new Circle(x, y, color, 2);

            baseShape.Move(2, 4);

            Assert.Equal(5, baseShape.GetX());
            Assert.Equal(6, baseShape.GetY());
        }
    }
}
