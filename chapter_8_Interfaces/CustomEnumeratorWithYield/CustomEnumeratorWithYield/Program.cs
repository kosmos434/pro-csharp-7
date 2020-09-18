using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            /// get items useing GEtenumerator()
            foreach (Car car in carLot)
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed}mph!!! cool");
            }
            Console.WriteLine();

            // now in reverse order
            foreach (Car car1 in carLot.GetTheCars(true))
            {
                Console.WriteLine($"{car1.PetName} is going {car1.CurrentSpeed}");
            }
        Console.ReadLine();
        }
    }
}
