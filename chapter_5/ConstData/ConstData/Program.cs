using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- fun with Const -------\n");
            Console.WriteLine("the value of PI is {0}", MyMathClass.PI);
            // Error! you can't change a constant!
            // MyMathClass.PI = 3.1444;

            LocalConstStringVariable();

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            // a local constant data point can be directly accessed
            const string fixedStr = "Fixed string data here";
            Console.WriteLine(fixedStr);

            //Error!
            // fixedStr = "This will not work!";
        }
    }
}
