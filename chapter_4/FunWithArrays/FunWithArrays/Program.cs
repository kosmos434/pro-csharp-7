using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with arrays *****");
            //SimpleArrays();
            //ArrayInitialization();
            //DeclareImplicitArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedMDArray();
            //PassAndReceiveArrays();
            SystemArrayMethods();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("===> simple array creation");
            // create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // now print out each array item
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }

            // now create a 100 item string array, indexed 0-99
            string[] booksOnDotNet = new string[100];       // 100 is the total of items, not the upper bound
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("==> array initizliation");

            // array initialization syntax using new keyword
            string[] stringArray = new string[] { "one", "two", "threeeee" };
            Console.WriteLine($"stringarra has {stringArray.Length} elements in it yay");

            // array initiazliation syntax w/o using the new keyword
            bool[] boolArray = { false, false, true };          // size is inferred here
            Console.WriteLine($"boolArray has {boolArray.Length} elements in it yay");

            // array initizliation with new keywor AND size
            int[] intArray = new int[4] { 33, 55, 22, 66 };
            Console.WriteLine($"intArray totaly has {intArray.Length} elements in it yay");
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("==> implicit array initializtion");

            // a is really int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine($"a is a {a.ToString()}");

            // b is really a double[]!!
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine($"b is a {b.ToString()}");

            // c is a string[] array
            var c = new[] { "hey" };
            Console.WriteLine($"c is a {c.ToString()}");
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("--------an array with objects --------");

            // an array of objects can be anything at all
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1999, 3, 22);
            myObjects[3] = "this is a string";

            foreach (object obj in myObjects)
            {
                // print the type and value for each item in the array
                Console.WriteLine($"type: {obj.GetType()} value: {obj}");
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("pepperoni and chease");
            // a rectangular MD array
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // populate a (3 * 4) array
            for (int i = 0; i < 3; i++)         // these are no brackets
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // print our 3 * 4 array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMDArray()
        {
            Console.WriteLine("jagged MD array");
            // a jagged MD array (an array of arrays)
            // here we have an array of 5 different arrays
            int[][] myJagArray = new int[5][];

            // create the jg array
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // print each row (remembering each element is defaulted to zero!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine($"Item {i} is {myInts[i]}");
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("====> arrays as params and return values");
            // pass array as parameter!!
            int[] ages = { 20, 22, 55, 0 };
            PrintArray(ages);

            // get array as return value
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }


        static void SystemArrayMethods()
        {
            Console.WriteLine("working with System.Array");
            // initialize the items at startup
            string[] bands = { "Slipknot", "Korn", "Incubus" };

            // print out names in declared order
            Console.WriteLine("====> here is the array:");
            for (int i = 0; i < bands.Length; i++)
            {
                // print a band name!!
                Console.Write(bands[i] + ", ");
            }
            Console.WriteLine("\n");

            // now to reverse the list...
            Array.Reverse(bands);
            Console.WriteLine("==>> the reversed array!!");
            // and print out the bands!
            for (int i = 0; i < bands.Length; i++)
            {
                // name
                Console.Write(bands[i] + ", ");
            }
            Console.Write("\n");

            // clear out all but the first band
            Console.WriteLine("---> cleared out all but one...");
            Array.Clear(bands, 1, 2);

            for (int i = 0; i < bands.Length; i++)
            {
                // print a name
                Console.Write(bands[i] + ", ");
            }
            Console.WriteLine();
        }


    }
}
