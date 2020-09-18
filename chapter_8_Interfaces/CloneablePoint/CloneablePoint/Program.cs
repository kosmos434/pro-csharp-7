using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //// two references to the same object
            //// remember that a copy of a reference will point to the same object
            //Point p1 = new Point(50, 50);
            //Point p2 = p1;
            //p2.X = 0;
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.ReadLine();

            // Clone() returns a plain object type
            // have to perform an explicit cast to obtain the derived type
            //Point p3 = new Point(100, 100);
            //Point p4 = (Point)p3.Clone();

            //// change p4.X (which leaves p3.X alone)
            ////p4.X = 999;

            //Console.WriteLine(p3);
            //Console.WriteLine(p4);
            //Console.ReadLine();


            Console.WriteLine("cloned p3 stored in new Pont in p4");
            Point p3 = new Point(100, 100, "Hane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("before modification");
            Console.WriteLine("p3: " + p3);
            Console.WriteLine("p4: " + p4);
            p4.desc.PetName = "My new point";
            p4.X = 7777;

            Console.WriteLine("\n changed p4.desc.petName and p4.X");
            Console.WriteLine("after modification: ");
            Console.WriteLine("p3: " + p3);
            Console.WriteLine("p4: " + p4);

            Console.ReadLine();
        }
    }
}
