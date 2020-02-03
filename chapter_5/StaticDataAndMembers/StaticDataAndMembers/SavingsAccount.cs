using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // instance level data
        public double currBalance;
        // STATIC data: shared among all objects of this class
        public static double currInterestRate;


        // constructor
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // static constructor!!
        // for static fields
        static SavingsAccount()
        {
            Console.WriteLine("in the static ctor");
            currInterestRate = 0.04;
        }





        // static members to get/set interest rate
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }


    }// end class
}// end namespace
