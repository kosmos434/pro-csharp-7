using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fun with Automatic Properties -----\n");

            Car c = new Car();
            c.PetName = "Daryl";
            c.Speed = 44;
            c.Color = "Pink";
            Console.WriteLine("this car is named {0}", c.PetName);
            c.DisplayStats();


            // Put car in the garage
            Garage g = new Garage();
            // ok, prints the default value of zero
            //Console.WriteLine("number of cars: {0}", g.NumberOfCars);
            // runtime error! backing field is currently null!
            //Console.WriteLine(g.MyAuto.PetName);

            g.MyAuto = c;
            Console.WriteLine("number of cars: {0}", g.NumberOfCars);
            Console.WriteLine("this car is named {0}", g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}