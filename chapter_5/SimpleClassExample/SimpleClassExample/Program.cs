using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Fun with class types -----\n");

            // allocate and configure a Car object
            //Car myCar = new Car();
            //myCar.petName = "Hank";
            //myCar.currSpeed = 30;

            //// speed up the car a bit and print
            //// the new state
            //for (int i = 0; i <= 5; i++)
            //{
            //    myCar.SpeedUp(6);
            //    myCar.PrintState();
            //}


            // objects making use of all of our constructors
            // make a car called 'Faulty' going 2mph
            //Car faulty = new Car();
            //faulty.PrintState();

            // make a car called 'Gary' going 0mph
            //Car gary = new Car("Gary");
            //gary.PrintState();

            // car called 'Sue' 88mph
            //Car biff = new Car("Biff", 88);
            //biff.PrintState();


            // motorcycle time
            //Motorcycle mc = new Motorcycle(5);
            //mc.PopAWheely();

            // make a motorcycle with a rider named 'Geoff'??
            // using this.name we have no problem
            //Motorcycle mc2 = new Motorcycle(5);
            //mc2.SetDriverName("Geoff");
            //mc2.PopAWheely();
            //Console.WriteLine("rider is named {0} ??", mc2.name); // <-- empty value!!

            //Motorcycle mc3 = new Motorcycle(20, "dobby");
            //Console.WriteLine(mc3.driverName);
            //Console.WriteLine(mc3.driverIntensity);
            //mc3.PopAWheely();

            //Motorcycle mc4 = new Motorcycle(5);
            //mc4.SetDriverName("Zavier");
            //Console.WriteLine(mc4.driverName);
            //Console.WriteLine(mc4.driverIntensity);
            //mc4.PopAWheely();



            MakeSomeBikes();

            Console.ReadLine();
        }// end main



        static void MakeSomeBikes()
        {
            // driverName = "", driverIntensity = 0
            Motorcycle b1 = new Motorcycle();
            Console.WriteLine("name is {0}, intensity is {1}", b1.driverName, b1.driverIntensity);

            // driverName = "Shrek", driverIntensity = 0
            Motorcycle b2 = new Motorcycle(name: "Shrek");
            Console.WriteLine("name is {0}, intensity is {1}", b2.driverName, b2.driverIntensity);

            // driverName = "", driverIntensity = 55
            Motorcycle b3 = new Motorcycle(intensity: 55);
            Console.WriteLine("name is {0}, intensity is {1}", b3.driverName, b3.driverIntensity);

            // driverName = "Donkey", driverIntensity = 99
            Motorcycle b4 = new Motorcycle(intensity: 99, name: "Donkey");
            Console.WriteLine("name is {0}, intensity is {1}", b4.driverName, b4.driverIntensity);

        }//end method


    }// end class

}// end namespace
