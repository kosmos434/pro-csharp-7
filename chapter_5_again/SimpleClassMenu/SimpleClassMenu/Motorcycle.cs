using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassMenu
{
	class Motorcycle
	{
		public int driverIntensity;
		public string driverName;

		////ctors (with chaining)
		//public Motorcycle() { }
		//public Motorcycle(int intensity) :this(intensity, ""){ }
		//public Motorcycle(string name) : this(0, name) { }
		////master ctor
		//public Motorcycle(int intensity, string name)
		//{
		//	if (intensity > 10)
		//	{
		//		intensity = 10;
		//	}
		//	driverIntensity = intensity;
		//	driverName = name;

		//}

		// single uber ctor
		public Motorcycle(int intensity = 0, string name = "")
		{
			if (intensity > 10)
			{
				intensity = 10;
			}
			driverIntensity = intensity;
			driverName = name;
		}





		public void SetDriverName(string name) => this.driverName = name;


		//methods
		public void PopAWheely()
		{
			for (int i = 0; i <= driverIntensity; i++)
			{
				Console.WriteLine("Yippee ki yay!!");
			}
		}


	}
}
