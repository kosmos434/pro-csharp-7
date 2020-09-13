using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRevenge
{
    abstract partial class Employee
    {


        // Methods.
        // Virtual means this can be overridden in a derived class to suit it's needs
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"id: {ID}");
            Console.WriteLine($"pay: {Pay}");
            Console.WriteLine($"age: {Age}");
        }
    }
}
