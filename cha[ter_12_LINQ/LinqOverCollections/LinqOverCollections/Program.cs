using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------fun with lnq over generic collections yeehaw--------------");
            List<Car> myCars = new List<Car>()
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            //GetFastCars(myCars);
            GetFastBeemers(myCars);

            Console.ReadLine();
        }

        static void OfTypeAsFilter()
        {
            // extract the ints from ArrayList
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStuff.OfType<int>();

            // prints out 10, 500l etc, just te ints
            foreach (int i in myInts)
            {
                Console.WriteLine("int value: " + i);
            }
        }

        static void LINQOverArrayList()
        {
            Console.WriteLine("***********linq over ArrayList*********");
            // here isa nongeneric collection of cars
            ArrayList myCars = new ArrayList()
            {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            // transform ArrayList into an IEnumberable<T> compatible type
            var myCarsEnum = myCars.OfType<Car>();

            // create a query expression targeting the compatible type
            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine(car.PetName + " is going hella fast");
            }
        }

        static void GetFastBeemers(List<Car> myCars)
        {
            // find the beems
            var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;
            foreach (var c in fastCars)
            {
                Console.WriteLine(c.PetName + " is going too and it s a bmw yay");
            }
        }

        static void GetFastCars(List<Car> myCars)
        {
            // find all Car objects in the LIst<> where the speed is > 55
            var fastCars = from c in myCars where c.Speed > 55 select c;

            foreach (var carvar in fastCars)
            {
                Console.WriteLine(carvar.PetName + " is going too fast honk honk");
            }
        }
    }

    class Car
    {
        public string PetName { get; set; } = "";
        public string Color { get; set; } = "";
        public int Speed { get; set; }
        public string Make { get; set; } = "";
    }
}
