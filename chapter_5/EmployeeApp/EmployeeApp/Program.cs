using System;


namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fun with Encapsulation -----\n");

            //Employee emp = new Employee("Dingus", 0451, 30_000);
            //emp.GiveBonus(3333);
            //emp.DisplayStats();

            // reset and then get the Name property
            //emp.Name = "Krevin";
            //Console.WriteLine("employee is named: {0}", emp.Name);

            //Employee joe = new Employee();
            //joe.Age++;
            //joe.DisplayStats();


            Console.ReadLine();



            //// use the getter/setter methods to interact with the object's name
            //emp.SetName("Dr. Dingle");
            //Console.WriteLine("this employee is now named {0}", emp.GetName());


            //Employee emp2 = new Employee("Conan", 222, 11_1111);
            //emp2.DisplayStats();
            //// error, too long
            //emp2.SetName("Conan the mighty Barbarian");
            //emp2.DisplayStats();


            // error! can't directly access private members
            // from an object
            //emp.empName = "Stingus";
        }
    }
}
