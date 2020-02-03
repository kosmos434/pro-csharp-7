using System;



namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fun with static classes -----\n");

            // this is just fine
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // compiler error! can't create instance of static classes!
            //TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();

        }// end main

    }// end class

}// end namespace
