using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    // a custom enumeration (enum)
    // also enums are not enumerators..

    enum EmpType
    {
        Manager, // = 0
        Grunt, // = 1
        Contractor, // = 2
        VicePresident // = 3
    }

    //or not zero indexed
    //enum EmpType
    //{
    //    Manager = 103, // = 103
    //    Grunt, // = 104
    //    Contractor, // = 105
    //    VicePresident // = 106
    //}

    // or note sequential at all..
    //enum EmpType
    //{
    //    Manager = 2,
    //    Grunt = 22,
    //    Contractor = 5,
    //    VicePresident = 102
    //}


    // or a different type of enums
    // a byte
    //enum EmpType : byte
    //{
    //    Manager = 10,
    //    Grunt = 1,
    //    Contractor = 100,
    //    VicePresident = 30
    //}






    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with enums*******");
            // make an EmpType variable
            //EmpType emp = EmpType.VicePresident;
            //AskForBonus(emp);


            // print storage for the enum
            //Console.WriteLine("EmpType uses a {0} for storage",
            //    Enum.GetUnderlyingType(emp.GetType()));

            // this time use typeof to extract a type
            //Console.WriteLine("EmpType uses a {0} for storage",
            //    Enum.GetUnderlyingType(typeof(EmpType)));


            // type of enum variable
            // Prints out "emp is a vice president"
            //Console.WriteLine("emp is a {0}", emp.ToString());


            // prints out value of enum variable
            //prints out vice president... some number
            //Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);



            EmpType e2 = EmpType.Contractor;

            // these types are enums in the System namespace
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.ReadLine();
        }

        // enums as parameters
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have gotta be kidding");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You got enough cash");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("O-of course your majesty");
                    break;
            }
        }



        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("===> info about {0}", e.GetType().Name);

            Console.WriteLine("underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            // get all name-value pairs for incoming parameter
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("this enum has {0} members", enumData.Length);

            // now show the string name and associated value, 
            // using the d format flag
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("name: {0}, value: {0:D}",
                    enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
