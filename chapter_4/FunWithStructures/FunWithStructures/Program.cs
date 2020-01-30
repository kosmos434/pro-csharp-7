using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** first look at structures *********");

            // create an initial Point
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // adjusting the X and Y values
            myPoint.Increment();
            myPoint.Display();

            // calling with new
            //sets all fields to default values, 
            // 0 in the case of ints

            Point p1 = new Point();

            // Printx X=0 Y=0
            p1.Display();

            // calling a custom constructor
            Point p2 = new Point(50, 60);

            // prints X=50 Y=60
            p2.Display();



            
            


            Console.ReadLine();
        }


        // local structures are popped
        // the stack when a method returns
        static void LocalValueTypes()
        {
            // recall "int" is really a System.Int32 structure
            int i = 0;

            //recall "Point" is a structure type
            Point p = new Point();
        } // <---- "p" pops off the stack here

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
