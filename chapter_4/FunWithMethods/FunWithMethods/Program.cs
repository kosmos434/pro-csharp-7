using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with methods********");

            // pass two variables in by value
            //int x = 9, y = 10;
            //Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            //Console.WriteLine("Answer is: {0}", Add(x, y));
            //Console.WriteLine("After call: X: {0}, Y: {1}", x, y);


            // no need to assigne initial values to local variables
            // used as output parameters, provided the first time
            // you use them is as output arguments
            // C# 7 allows for out parameters to be declared in the method call
            //Add(90, 90, out int ans);
            //Console.WriteLine("90 + 90 = {0}", ans);



            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);

            //Console.WriteLine("INt is : {0}", i);
            //Console.WriteLine("SStr is : {0}", str);
            //Console.WriteLine("Bool is : {0}", b);



            //string str1 = "Flip";
            //string str2 = "Flop";
            //Console.WriteLine("Before: {0}, {1} ", str1, str2);

            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1} ", str1, str2);

            // flip flop
            // flop flip





            //string[] stringArray = { "one", "two", "three" };
            //int pos = 1;

            // returning a reference
            //Console.WriteLine("----> Using ref return");
            //Console.WriteLine("Before: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            //ref var refOutput = ref SampleRefReturn(stringArray, pos);
            //refOutput = "new";
            //Console.WriteLine("After: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);


            // Params[]
            // pass in a comma-delimited list of doubles
            //double average;
            //average = CalculateAverages(4.3, 3.2, 5.2, 5.1, 66.3, 66.1);
            //Console.WriteLine("average of data is: {0}", average);

            // or pass an array of double
            //double[] data = { 4.5, 1.3, 5.5 };
            //average = CalculateAverages(data);
            //Console.WriteLine("average of data is: {0}", average);

            // and checking what 0 averaged will be
            //Console.WriteLine("average of data 0 is {0}", CalculateAverages());



            //EnterLogData("Oh no! grid cant find data");
            //EnterLogData("Oh no! I cant find the payroll data", "CFO");





            // named parameters
            DisplayFancyMessage(message: "Wow! a fancy message, great", 
                textColor: ConsoleColor.DarkRed, 
                backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Test test test...",
                textColor: ConsoleColor.DarkBlue);




            Console.ReadLine();

        }

        // Arguments are passed by value by default!!
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
            // caller will not see these changes
            // as you are modifying a copy
            // of the original data
            x = 100000;
            y = 888888;
            return;
        }


        // returning multiple output parameters
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }



        // reference parameters
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }


        //returning a reference
        // this returns a reference to "two"
        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }



        // return  the average of "some number" of doubles'
        static double CalculateAverages(params double[] values)
        {
            Console.WriteLine("You sent to me {0} doubles", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }



        //optional parameters
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            // note that 'progammer' here is the default owner variable
            Console.WriteLine("Owner of erro: {0}", owner);
        }



        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            // set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
