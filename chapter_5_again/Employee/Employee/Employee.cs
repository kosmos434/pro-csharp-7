using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    partial class Employee
    {


        // Methods.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"id: {ID}");
            Console.WriteLine($"pay: {Pay}");
            Console.WriteLine($"age: {Age}");
        }
    }
}
