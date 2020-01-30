using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* 'Fun' with type conversions ************");

            // add two shorts and print the result
            short numb1 = 30000, numb2 = 30000;

            // Explicitly cast the int into a short(and allow loss of data)
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}",
                numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();
        }


        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            // Explicitly cast the int into a byte (no loss of data)
            myByte = (byte)myInt;
            Console.WriteLine("value of myByte: {0}", myByte);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
