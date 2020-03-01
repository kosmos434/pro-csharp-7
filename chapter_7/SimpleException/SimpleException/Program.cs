using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Simple Exception Example... with cars ***********");
            Console.WriteLine("----> creating a car and flooring it");
            Car myCar = new Car("Interceptor", 20);
            myCar.CrankTunes(false);


            // speed up past the cars max speed to trigger an exception
            try { 
            for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);
            }//end try

            // TargetSite actually returns a MethodBase object
            catch(Exception e)
            {
                Console.WriteLine("\n*****Error!!****");
                Console.WriteLine($"method {e.TargetSite}");
                //Console.WriteLine($"class defining member {e.TargetSite.DeclaringType}");
                //Console.WriteLine($"member type {e.TargetSite.MemberType}");
                Console.WriteLine($"message {e.Message}");
                Console.WriteLine($"source {e.Source}");
                //Console.WriteLine($"stack {e.StackTrace}");
                //Console.WriteLine($"help link url {e.HelpLink}");
                Console.WriteLine("\n -> Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine($"--> {de.Key}: {de.Value}<--");
            }

            // the error has been handled, processsing continues with the next statement
            Console.WriteLine("\n***** out of exception handling logic *****");
            Console.ReadLine();
        }
    }
}
