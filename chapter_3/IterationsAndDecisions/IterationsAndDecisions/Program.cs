using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoopExample();
            //ForEachLoopExample();
            //LinqQueryOverInts();
            //WhileLoopExample();
            //DoWhileLoopExample();
            //ExecuteIfElseUsingConditionalOperator();
            //SwitchExample();
            //SwitchOnStringExamples();
            //SwitchOnEnumExample();
            //SwitchWithGoto();
            //ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchesWithWhen();
            Console.ReadLine();
        }


        // basic for loop
        static void ForLoopExample()
        {
            // note "i" is only visible within the scope of the for loop
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("number is {0}", i);
            }
            // "i" is not visible here nyan
            {

            }
        }

        // Iterate array items linearly (n+1) with the power of foreach
        static void ForEachLoopExample()
        {
            string[] carTypes = { "ford", "bmw", "audi", "tesla" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 33, 55, 66 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 40, 50, 60, 1, 3, 5, 6 };

            // LINQ query time
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values under 10 in this bad boy:");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }

        }


        static void WhileLoopExample()
        {
            string userIsDone = "";

            // test on a lower-class copy of the string
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("Trapped in the while loop..");
                Console.Write("Are you done [yes] [nes]: ");
                userIsDone = Console.ReadLine();
            }
        }



        static void DoWhileLoopExample()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("trapped in a do while loop");
                Console.Write("art thou done [yes] [nes]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // <--semicolon
        }



        // aka ternary operator
        // condition ? if true : else
        private static void ExecuteIfElseUsingConditionalOperator()
        {
            //string stringData = "My texty data";
            string stringData = "text";
            Console.WriteLine($"string is {stringData}");
            Console.WriteLine(stringData.Length > 6
                ? "string is greater than 6 chars"
                : "string is lesser than 6 char");
            Console.WriteLine();
        }


        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("nice, c it is");
                    break;
                case 2:
                    Console.WriteLine("okay vb then, cool");
                    break;
                default:
                    Console.WriteLine("something else then, cool");
                    break;
            }

        }


        static void SwitchOnStringExamples()
        {
            Console.WriteLine("c or vb");
            Console.Write("please pick your language pref ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "c":
                    Console.WriteLine("c, nice");
                    break;
                case "vb":
                    Console.WriteLine("vb, that's cool");
                    break;
                default:
                    Console.WriteLine("another thing, wow");
                    break;
            }
        }



        static void SwitchOnEnumExample()
        {
            Console.Write("What is your favorite day of the week ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("bad input!!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("nice");
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("weekday, lame");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Cool");
                    break;
                default:
                    Console.WriteLine("not nice");
                    break;
            }
            Console.WriteLine();
        }



        public static void SwitchWithGoto()
        {
            var foo = 5;
            switch (foo)
            {
                case 1:
                    // do something
                    goto case 2;
                case 2:
                    // do somethin else
                    break;
                case 3:
                    // another another action
                    goto default;
                default:
                    // default action
                    Console.WriteLine("well that it for a switch with gotos");
                    break;

            }
        }


        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;

            // standard constant pattern switch statement to set up example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5m;
                    break;
                default:
                    choice = 9;
                    break;
            }

            // new hotness, with pattern matching
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is string {0}", s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}", d);
                    break;
                default:
                    Console.WriteLine("Your choice is a weird thing");
                    break;

            }
            Console.WriteLine();


        }



        static void ExecutePatternMatchingSwitchesWithWhen()
        {
            Console.WriteLine("1 [C#] 2 [VB]");
            Console.Write("Pick your lang pref: ");

            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: wonderful choice i guess");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("C#: neat");
                    break;
                default:
                    Console.WriteLine("Other choice, great..");
                    break;
            }
            Console.WriteLine();
        }
    }
}
