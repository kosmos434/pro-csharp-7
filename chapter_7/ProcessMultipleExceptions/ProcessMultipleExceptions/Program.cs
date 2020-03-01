using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Handling multiple exceptions *******\n");
            Car myCar = new Car("Drivey", 90);
            //myCar.Accelerate(2000);
            myCar.CrankTunes(true);

            try
            {
                // trip Arg out of range exception
                myCar.Accelerate(-5);
            }
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                // This line will only print  if the 'when' clause evaluates to true (not on friday)
                Console.WriteLine("Catching car is dead");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // the catch all exception for everything beyond 
            // CarIsDeadException and ArgumentOutOfRangeException
            // (must come after the more specific ones)
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // this will always occur, exceptions or no
                myCar.CrankTunes(false);
            }



            Console.ReadLine();
        }
    }
}
