using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassMenu
{
	class Car
	{
		// state of the 'car'
		public string petName;
		public int currSpeed;//field data shouldn't be public


		#region ctors
		public Car() { }	// defaultest ctor
		public Car(string petName)
			=> this.petName = petName;	//expression bodied syntax (arrow style)

		public Car(int currSpeed)
		{
			this.currSpeed = currSpeed;
		}

		public Car(string petName, int currSpeed)
		{
			this.petName = petName;
			this.currSpeed = currSpeed;
		}
		#endregion



		//functionality
		//uses expression bodied syntax (arrow function)
		public void PrintState()
			=> Console.WriteLine($"{petName} is going {currSpeed} mph");

		public void SpeedUp(int delta)
			=> currSpeed += delta;

		

	}

}
