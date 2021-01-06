using System.Drawing;

namespace Domain
{
    public class Circle: BaseShape
    {
        public int Radius { get; private set; }       

        public Circle(int x, int y, Color color, int radius) :base(x, y, color)
        {
            Radius = radius;
        }

        public override int GetHeight()
        {
            return Radius * 2;
        }

        public override int GetWidth()
        {
            return Radius * 2;
        }
    }
}