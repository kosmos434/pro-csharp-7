using System;

namespace ObjectInit
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Object initialization syntax
            Point lastPoint = new Point() { X = 30, Y = 30 };
            lastPoint.DisplayStats();


            // Create and init a Rectangle.
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
        }
    }
}
