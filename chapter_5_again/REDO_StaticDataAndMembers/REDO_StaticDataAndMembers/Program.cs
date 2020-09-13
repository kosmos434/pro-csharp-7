using System;

namespace REDO_StaticDataAndMembers
{
    class Program
    {
		static void Main(string[] args)
		{
			SavingsAccount s1 = new SavingsAccount(50);
			Console.WriteLine($"interest rate is {SavingsAccount.InterestRate}");
			SavingsAccount.SetInterestRate(0.99);
			SavingsAccount s2 = new SavingsAccount(100);
			Console.WriteLine($"interest rate is {SavingsAccount.InterestRate}");


			//// new object with shared interest rate still
			//SavingsAccount s3 = new SavingsAccount();
			//Console.WriteLine($"interest rate is now {SavingsAccount.GetInterestRate()}");
		}
	}
}
