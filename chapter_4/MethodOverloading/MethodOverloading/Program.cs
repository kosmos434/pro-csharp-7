using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************'Fun' with method overloading*******\n");

            // calls in version of Add()
            Console.WriteLine(Add(10, 10));

            // call long version
            Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

            // calls double version
            Console.WriteLine(Add(4.2, 6.1));

            Console.ReadLine();
            
        }





        // overloaded Add() method
        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
