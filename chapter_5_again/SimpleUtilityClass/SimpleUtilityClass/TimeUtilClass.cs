using System;
using System.Collections.Generic;
using System.Text;
using static System.DateTime;   // to shorten
using static System.Console;

namespace SimpleUtilityClass
{
    static class TimeUtilClass
    {
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate()
            => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}
