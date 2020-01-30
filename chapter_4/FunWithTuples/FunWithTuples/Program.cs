using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var values = ("a", 5, "c");
            //Console.WriteLine($"First item: {values.Item1}");
            //Console.WriteLine($"Second item: {values.Item2}");
            //Console.WriteLine($"Third item: {values.Item3}");

            //var valuesWithNames = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

            //// using field names
            //Console.WriteLine($"FIrst item: {valuesWithNames.FirstLetter}");
            //Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            //Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

            //// or with regular item notation
            //Console.WriteLine($"FIrst item: {valuesWithNames.Item1}");
            //Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            //Console.WriteLine($"Third item: {valuesWithNames.Item3}");

            //Console.WriteLine("----> Inferred tuple names");
            //var foo = new { Prop1 = "first", Prop2 = "second" };
            //var bar = new { foo.Prop1, foo.Prop2 };
            //Console.WriteLine($"{bar.Prop1};{bar.Prop2}");


            //var samples = FillTheseValues();
            //Console.WriteLine($"Int item: {samples.a}");
            //Console.WriteLine($"string item: {samples.b}");
            //Console.WriteLine($"bool item: {samples.c}");


        }

        // tuples as Method return values
        // this clunkily returns three values 'out'
        //static void FillTheseValues(out int a, out string b, out bool c)
        //{
        //    a = 9;
        //    b = "Enjoy this delicious string";
        //    c = true;
        //}

        // tuple style
        //static (int a, string b, bool c) FillTheseValues()
        //{
        //    return (9, "Enjoy this more delicious string", true);
        //}

        
    }
}
