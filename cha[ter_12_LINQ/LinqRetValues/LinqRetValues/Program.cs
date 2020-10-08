using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fuuuun with linq return values\n");
            //IEnumerable<string> subset = GetStringSubset();

            //foreach (string item in subset)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (string item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            // note subset is an IEnumberable<string> compatible object
            //IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;

            // let's use var tho
            var theRedColors = from c in colors where c.Contains("Red") select c;

            // map the results into an array
            return theRedColors.ToArray();
        }
    }
}
