using System;
using System.Collections.Generic;
using System.Text;

namespace REDO_StaticDataAndMembers
{
	class SavingsAccount
	{
		public double currBalance;
		// static (shared) data
		public static double currInterestRate;

		// Static property.
		public static double InterestRate
		{
			get {return currInterestRate;}
			set {currInterestRate = value;}
		}
		
		// static ctor
		// used when the static data is not known at compile time
		// like when read from an external file, or you need a random number
		static SavingsAccount()
		{
            Console.WriteLine("in a static ctor");
			currInterestRate = 0.04;
		}

        public SavingsAccount(double currBalance)
        {
            this.currBalance = currBalance;
        }



        // static methods time
        public static void SetInterestRate(double newRate)
		{ currInterestRate = newRate; }

		public static double GetInterestRate()
		{ return currInterestRate; }
	}
}
