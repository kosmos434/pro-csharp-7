using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRevenge
{
    class Manager : Employee
    {
        public Manager() { }
        // Constructor chaining through parent class. Neat.
        // Note the base keyword instead of this.
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            :base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }
            
        public int StockOptions { get; set; }

        // Methods.
        // Override method.
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Stock options: {StockOptions}");
        }
    }
}
