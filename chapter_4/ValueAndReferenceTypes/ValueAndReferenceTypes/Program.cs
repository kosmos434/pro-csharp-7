using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValueTypesAssignment();
            //ReferenceTypeAssignment();
            ValueContainingRefType();
            Console.ReadLine();

        }


        // assigning two intrinsic value types results in
        // two independent variables on the stack
        //static void ValueTypesAssignment()
        //{
        //    Console.WriteLine("assigning value type \n");

        //    Point p1 = new Point(10, 10);
        //    Point p2 = p1;

        //    // print both points
        //    p1.Display();
        //    p2.Display();

        //    // change p1.X and print again... p2.X is not changed
        //    p1.X = 100;
        //    Console.WriteLine("\n====> Changed p1.X\n");
        //    p1.Display();
        //    p2.Display();

        //}

        //static void ReferenceTypeAssignment()
        //{
        //    Console.WriteLine("assigning reference type\n");
        //    PointRef p1 = new PointRef(10, 10);
        //    PointRef p2 = p1;

        //    // print both point refs
        //    p1.Display();
        //    p2.Display();

        //    // change p1.X and print again..
        //    // what will happen when p1 and p2 are references..
        //    p1.X = 100;
        //    Console.WriteLine("\n ---> changed p1.X\n");
        //    p1.Display();
        //    p2.Display();
        //}


        static void ValueContainingRefType()
        {
            // create the first Rectangle
            Console.WriteLine("--> creating r1");
            Rectangle r1 = new Rectangle("first rect", 10, 10, 50, 50);

            // now assign a new Rectangle to r1
            Console.WriteLine("--> assigning r2 to r1");
            Rectangle r2 = r1;

            // change some values of r2..
            Console.WriteLine("--> changing values of r2");
            r2.RectInfo.InfoString = "This is new info, neew new new";
            r2.RectBottom = 4444;

            // print values of both rectangles for comparison
            r1.Display();
            r2.Display();
        }

    }


    // this is the reference type within rectangle objects
    class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo(string info)
        {
            InfoString = info;
        }
    }

    struct Rectangle
    {
        // the rectangle structure contains a reference type member
        public ShapeInfo RectInfo;

        public int RectTop, RectLeft, RectBottom, RectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectBottom = bottom;
            RectLeft = left; RectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                "Left = {3}, Right = {4}",
                RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
        }
    }




    // classes are always reference types
    class PointRef
    {
        // same members as the Point structure VVV

        // fields of the structure
        public int X;
        public int Y;

        // a custom constructor
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        // add 1 to the (X,Y) position
        public void Increment()
        {
            X++; Y++;
        }

        // subtract 1 from the (X,Y) position
        public void Decrement()
        {
            X--; Y--;
        }

        // display the current position
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }




    struct Point
    {
        // fields of the structure
        public int X;
        public int Y;

        // a custom constructor
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        // add 1 to the (X,Y) position
        public void Increment()
        {
            X++; Y++;
        }

        // subtract 1 from the (X,Y) position
        public void Decrement()
        {
            X--; Y--;
        }

        // display the current position
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
