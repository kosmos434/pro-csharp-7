using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- fun with object init syntax -------\n");

            // make a point by setting each property manually
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // or make a point via a custom constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // or make a point using object init syntax
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();


            // calling a more interesting custom constructor with init syntax
            Point goldPoint = new Point(PointColor.LightBlue) { X = 90, Y = 20 };
            goldPoint.DisplayStats();



            // create and initialize a Rectangle
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };

            Console.ReadLine();
        }
    }
}
