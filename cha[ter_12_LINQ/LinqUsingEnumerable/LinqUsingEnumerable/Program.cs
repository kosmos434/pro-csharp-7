using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryStringWithOperators();
            //QueryStringWithEnumerableLambdas();
            //QueryStringsWithAnonymousMethods();
        }

        // using anon expressions
        //static void QueryStringsWithAnonymousMethods()
        //{
        //    Console.WriteLine("***** Using Anonymous Methods *****");

        //    string[] currentVideoGames = {"Morrowind", "Uncharted 2",
        //        "Fallout 3", "Daxter", "System Shock 2"};

        //    // Build the necessary Func<> delegates using anonymous methods.
        //    Func<string, bool> searchFilter =
        //        delegate (string game) { return game.Contains(" "); };
        //    Func<string, string> itemToProcess = delegate (string s) { return s; };

        //    // Pass the delegates into the methods of Enumerable.
        //    var subset = currentVideoGames.Where(searchFilter)
        //        .OrderBy(itemToProcess).Select(itemToProcess);

        //    // Print out the results.
        //    foreach (var game in subset)
        //        Console.WriteLine("Item: {0}", game);
        //    Console.WriteLine();
        //}

        // uing lambdas
        static void QueryStringWithEnumerableLambdas()
        {
            string[] currVideoGames = {"Morrowind", "Uncharted 2",
                                "Fallout 3", "Daxter", "System Shock 2"};

            // build a query expression using extension methods
            // granted to the Array vis the Enumerable type
            //var subset = currVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);


            // Break it down!
            var gamesWithSpaces = currVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);

            foreach (var item in subset)
            {
                Console.WriteLine("item " + item);
            }
        }

        // simple way
        static void QueryStringWithOperators()
        {
            Console.WriteLine("using query operators");

            string[] currVideoGames = {"Morrowind", "Uncharted 2",
                                "Fallout 3", "Daxter", "System Shock 2"};

            var subset = from game in currVideoGames
                         where game.Contains(" ")
                         orderby game
                         select game;
            foreach (string s in subset)
            {
                Console.WriteLine("item " + s);
            }
        }
    }
}
