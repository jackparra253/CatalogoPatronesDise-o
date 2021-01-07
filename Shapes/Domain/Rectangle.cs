using System;
using System.Drawing;

namespace Domain
{
    public class Rectangle: BaseShape
    {
        public Rectangle(int x, int y, int width, int height, Color color):base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public override int GetWidth()
        {
            return Width;
        }

        public override int GetHeight()
        {
            return Height;
        }
    }
}
