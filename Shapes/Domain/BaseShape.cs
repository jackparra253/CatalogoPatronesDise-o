using System.Drawing;

namespace Domain
{
    public abstract class BaseShape: IShape
    {
        public BaseShape(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
            Selected = false;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public Color Color { get; private set; }
        public bool Selected { get; private set; }

        public abstract int GetHeight();

        public abstract int GetWidth();

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public bool IsInsideBounds(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSelected()
        {
            return Selected;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Select()
        {
            Selected = true;
        }

        public void UnSelect()
        {
            Selected = false;
        }
    }
}