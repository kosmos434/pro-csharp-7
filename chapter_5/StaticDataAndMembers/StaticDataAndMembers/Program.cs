using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Fun with Static Data ----\n");
            //SavingsAccount s1 = new SavingsAccount(50);

            // print the current interest rate
            //Console.WriteLine("interest rate is {0}", SavingsAccount.GetInterestRate());

            // try to change the interest rate via property
            //SavingsAccount.SetInterestRate(0.99);

            // second account create
            //SavingsAccount s2 = new SavingsAccount(100);

            // print out new staticly changed interest rate
            //Console.WriteLine("interest rate now is {0}", SavingsAccount.GetInterestRate());


            //// make new object, this does NOT 'reset' the interest rate
            //SavingsAccount s3 = new SavingsAccount(10000.75);



            // print the current interest rate via property
            Console.WriteLine("interest rate is: {0}", SavingsAccount.InterestRate);

            Console.ReadLine();
        }
    }
}
