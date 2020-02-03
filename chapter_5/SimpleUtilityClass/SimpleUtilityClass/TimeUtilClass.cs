using System;
// import the static members of Console and DateTime
using static System.Console;
using static System.DateTime;

namespace SimpleUtilityClass
{
    // static classes can only
    // contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime() => WriteLine(Now.ToShortTimeString());

        public static void PrintDate() => WriteLine(Today.ToShortDateString());
    }// end class

}// end namespace
