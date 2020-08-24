using System;
using System.Collections.Generic;
using System.Text;

namespace REDO_StaticDataAndMembers
{
	class SavingsAccount
	{
		public double currBalance;

		// static (shared) data
		public static double currInterestRate = 0.04;

		public SavingsAccount(double balance)
		{
			currBalance = balance;
		}


		// static methods time
		public static void SetInterestRate(double newRate)
		{ currInterestRate = newRate; }

		public static double GetInterestRate()
		{ return currInterestRate; }
	}
}
