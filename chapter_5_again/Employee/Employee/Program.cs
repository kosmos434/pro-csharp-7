using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("mark", 456, 30_000);
            emp.SetName("bark");
            emp.GiveBonus(999);
            emp.DisplayStats();
        }
    }
}
