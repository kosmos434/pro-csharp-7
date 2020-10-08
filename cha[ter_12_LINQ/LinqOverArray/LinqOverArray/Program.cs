using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with linq objects\n");
            //QueryOverStrings();
            //QueryOverStringsWithExtensionMethods();
            QueryOverInts();
            Console.ReadLine();
        }

        static void ImmediateExecution()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // get the data RIGHT NOW as int[]
            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

            // get data RIGHT NOW as List<int>
            List<int> subsetAsListOfInts = (from i in numbers where i < 10 select i).ToList<int>();

            // or like this
            int[] subsetAsIntArray2 = (from i in numbers where i < 10 select i).ToArray();
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // print only items less than 10
            //IEnumerable<int> subset = from i in numbers
            //                          where i < 10
            //                          select i;

            // use implicit typing b/c LINQ types are complicated af
            var subset = from i in numbers
                         where i < 10
                         select i;

            // LINQ statement here
            foreach (var item in subset)
            {
                Console.WriteLine($"{item} < 10");
            }
            Console.WriteLine();
            // change some data hehe
            numbers[0] = -99999999;

            // now eval again
            foreach (var otheritem in subset)
            {
                Console.WriteLine($"{otheritem} < 10");
            }

            // impl typing here too
            // basically always use var when doing a LINQ query
            //foreach (var item in subset)
            //    Console.WriteLine("item: " + item);
            ReflectOverQueryResults(subset);
        }


        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"*****info about your query using {queryType}********");
            Console.WriteLine("resultSet is of type: " + resultSet.GetType().Name);
            Console.WriteLine("rresultset location: " + resultSet.GetType().Assembly.GetName().Name);
        }


        /// <summary>
        /// lambda expression one liner
        /// </summary>
        static void QueryOverStringsWithExtensionMethods()
        {
            // assusme we stiil have an array of strings
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "System Shock 2", "Tetris", "Mario Tennis" };

            // build a linqy extension query to find empty space items
            IEnumerable<string> subset =
                currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            ReflectOverQueryResults(subset, "Extension methods");

            // and print it
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }

        }

        /// <summary>
        /// this is called "query expression"
        /// </summary>
        static void QueryOverStrings()
        {
            // assume we have an aray of strings
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "System Shock 2", "Tetris", "Mario Tennis" };

            // build a query expression to find the items in the array
            // that have an embedded space
            IEnumerable<string> subset = from g in currentVideoGames 
                                         where g.Contains(" ") 
                                         orderby g 
                                         select g;

            ReflectOverQueryResults(subset);

            // and print out hte results
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }
}
