using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            // make an array of Car objects
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Marty", 88, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);




            // display current array
            Console.WriteLine("here is the unordered set of cars");
            foreach (Car car in myAutos)
                Console.WriteLine(car.CarID + " " + car.PetName);

            // now sort them using IComparable
            Array.Sort(myAutos);
            Console.WriteLine();

            // .. and display the sorted array
            Console.WriteLine("here they are ordered");
            foreach (Car car1 in myAutos)
                Console.WriteLine(car1.CarID + " " + car1.PetName);

            // now sort by petname
            Array.Sort(myAutos, new PetNameComparerizer());

            // dump sorted array
            Console.WriteLine("ordering by pet name");
            foreach(Car car2 in myAutos)
                Console.WriteLine(car2.CarID + " " + car2.PetName);


            Console.ReadLine();
        }
    }
}
