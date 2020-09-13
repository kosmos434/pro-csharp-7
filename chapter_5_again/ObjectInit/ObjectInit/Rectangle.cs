using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInit
{
    class Rectangle
    {
        Point topLeft = new Point();
        Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"topleft: {topLeft.X}, {topLeft.Y}, {topLeft.Color}" +
                $"bottomright: {bottomRight.X}, {bottomRight.Y}, {bottomRight.Color}");
        }
    }
}
