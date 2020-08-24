using System;

namespace SimpleClassMenu
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("fun with cars I suppose");

			// instance a car
			//Car myCar = new Car();
			//myCar.currSpeed = 10;
			//myCar.petName = "honky";

			//Car Mary = new Car("Mary");
			//Mary.PrintState();

			// speed up
			//for (int i = 0; i <= 10; i++)
			//{
			//	myCar.SpeedUp(4);
			//	myCar.PrintState();
			//}



			// now motocycles
			//Motorcycle mc = new Motorcycle(5);
			//mc.SetDriverName("Bikey");
			//mc.PopAWheely();
			//Console.WriteLine($"rider name is {mc.driverName}");
			//Console.ReadLine();

			// drivername = '', driverIntensity = 0
			Motorcycle m1 = new Motorcycle();
			Console.WriteLine($"name = {m1.driverName}, intensity = {m1.driverIntensity}");

			Motorcycle m2 = new Motorcycle(name:"testname");
			Console.WriteLine($"name = {m2.driverName}, intensity = {m2.driverIntensity}");

			Motorcycle m3 = new Motorcycle(35);
			Console.WriteLine($"name = {m3.driverName}, intensity = {m3.driverIntensity}");

		}
	}
}
