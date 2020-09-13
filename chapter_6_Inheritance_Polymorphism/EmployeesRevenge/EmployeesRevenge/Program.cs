using System;

namespace EmployeesRevenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalesPerson franco = new SalesPerson();
            //franco.Age = 99;
            //franco.Name = "Franxco";
            //franco.SalesNumber = 4;


            //Manager mg = new Manager("Joe", 55, 999, 1_000_000, "123-44-5678", 9000);
            //mg.GiveBonus(444);
            //mg.DisplayStats();
            //Console.WriteLine();

            //SalesPerson sp = new SalesPerson("Boe", 45, 499, 10_000, "424-44-5478", 4000);
            //sp.GiveBonus(90);
            //sp.DisplayStats();



            // Casting time
            //object frank = new Manager();
            //Hexagon hex;
            //try
            //{
            //    hex = (Hexagon)frank;
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            ArrayObjectObjects();
        }

        static void CastingExamples()
        {
            // a Manager "is a" System.Object, and an Employee
            object mang = new Manager("henk", 33, 4444, 33_999, "222-32-3245", 33333);
            // Have to downcast to promote this bad boy.
            GivePromotion((Manager)mang);

            Employee mang2 = new Manager("burt", 35, 3333, 22_888, "222-55-2344", 24324);
            GivePromotion(mang2);

            // a PTSalesPerson is of course a SalesPerson
            SalesPerson slsps = new PTSalesPerson("jim", 44, 234, 22_999, "234-44-6666", 90);
            GivePromotion(slsps);
        }

        static void GivePromotion(Employee emp)
        {
            // You can pass any descendent of Emplyee into this method

            //Console.WriteLine($"{emp.Name} was promoted");
            // Check if "is" a SalesPerson, then assign to variable s
            //if (emp is SalesPerson s)
            //{
            //    Console.WriteLine($"{emp.Name} made {((SalesPerson)emp).SalesNumber} sales");
            //    Console.WriteLine();
            //}
            //if (emp is Manager m)
            //{
            //    Console.WriteLine($"{emp.Name} had {((Manager)emp).StockOptions} stock options");
            //}

            // or just do this..
            Console.WriteLine($"{emp.Name} was promoted");
            switch (emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine($"{emp.Name} made {s.SalesNumber} sales");
                    break;
                case Manager m:
                    Console.WriteLine($"{emp.Name} had {m.StockOptions} stock options");
                    break;
            }
        }

        private static void ArrayObjectObjects()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thring";

            foreach (var item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("item is not a hexagon");
                else
                    h.Draw();
            }
        }
    }
}
