using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IShape
    {
        int GetX();
        int GetY();
        int GetWidth();
        int GetHeight();
        void Move(int x, int y);
        bool IsInsideBounds(int x, int y);
        void Select();
        void UnSelect();
        bool IsSelected();
        //void Paint(Graphics graphics);
    }
}
