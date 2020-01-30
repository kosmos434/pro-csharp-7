using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsolIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* BASIC CONSOLE I/O *********");
            //GetUserData();
            FormatNumericalData();
            //Console.WriteLine("{0}, Number {0}, Number {0}, Number {0}", 9);
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            // Get name and age
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, for fun heh
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console
            Console.WriteLine("Hello {0}! You are totally {1} years old",
                userName, userAge);

            // Restore previous color
            Console.ForegroundColor = prevColor;
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("THe value of 99999 in various formats");
            Console.WriteLine("c (currency): {0:c}", 99999);
            Console.WriteLine("d9 (9 decimals): {0:d9}", 99999);
            Console.WriteLine("f (fixed point): {0:f3}", 99999);
            Console.WriteLine("n (numeric with commas): {0:n}", 99999);
            Console.WriteLine();

            // Notice that upper or lowecasing for the hex determines
            // if the letters are upper or lowercased

            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

        }
    }
}
