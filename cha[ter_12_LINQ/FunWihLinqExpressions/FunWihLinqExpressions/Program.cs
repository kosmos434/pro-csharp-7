using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace FunWihLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%FUn with query expressions this isnt sql tho########");

            // this array will be the vasis of our testing...
            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo{ Name = "Mac's Coffee",
                                Description = "Coffee with TEETH",
                                NumberInStock = 24},
                new ProductInfo{ Name = "Milk Maid Milk",
                                Description = "Milk cow's love",
                                NumberInStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu",
                                Description = "Bland as Possible",
                                NumberInStock = 120},
                new ProductInfo{ Name = "Cruchy Pops",
                                Description = "Cheezy, peppery goodness",
                                NumberInStock = 2},
                new ProductInfo{ Name = "RipOff Water",
                                Description = "From the tap to your wallet",
                                NumberInStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza",
                                Description = "Everyone loves pizza!",
                                NumberInStock = 73}
            };

            // we will call various methods here yeehaw
            //GetOverStock(itemsInStock);
            //GetNamesAndDescs(itemsInStock);
            //GetCountFromQuery();
            //ReverseStuff(itemsInStock);
            //SoritItAlpha(itemsInStock);
            //DisplayDiff();
            //DisplayIntersection();
            //DispUnions();
            //DispConcat();
            //ConcatNoDupes();
            Agg();
            Console.ReadLine();
        }


        // aggregating
        static void Agg()
        {
            double[] winterTemps = { 2.4, -3.4, 8, -4, 9, 0, 9.3 };

            Console.WriteLine("max temp " + (from t in winterTemps select t).Max());
            Console.WriteLine("min temp " + (from t in winterTemps select t).Min());
            Console.WriteLine("avg temp " + (from t in winterTemps select t).Average());
            Console.WriteLine("sums " + (from t in winterTemps select t).Sum());
        }

        // venn diagramming it
        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "BMW", "Honda", "Proshe", "Hyundai" };
            List<string> yourCars = new List<string> { "BMW", "Toyota", "Honda" };

            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

            Console.WriteLine("here is the diff:");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        // intersecting it
        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "BMW", "Honda", "Proshe", "Hyundai" };
            List<string> yourCars = new List<string> { "BMW", "Toyota", "Honda" };

            // get common memmbers
            var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

            Console.WriteLine("here's the commons");
            foreach (var item in carIntersect)
            {
                Console.WriteLine(item);
            }
        }

        // unioning it
        static void DispUnions()
        {
            List<string> myCars = new List<string> { "BMW", "Honda", "Proshe", "Hyundai" };
            List<string> yourCars = new List<string> { "BMW", "Toyota", "Honda" };

            // get the uniond of these containers
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

            Console.WriteLine("here is EVERYTHIGN");
            foreach (var item in carUnion)
            {
                Console.WriteLine(item);
            }
        }


        // and fianlly concatting things
        // unioning even repeats
        static void DispConcat()
        {
            List<string> myCars = new List<string> { "BMW", "Honda", "Proshe", "Hyundai" };
            List<string> yourCars = new List<string> { "BMW", "Toyota", "Honda" };

            var carConc = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            foreach (var item in carConc)
            {
                Console.WriteLine(item);
            }
        }

        static void ConcatNoDupes()
        {
            List<string> myCars = new List<string> { "BMW", "Honda", "Proshe", "Hyundai" };
            List<string> yourCars = new List<string> { "BMW", "Toyota", "Honda" };
            
            var carConc = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            foreach (var item in carConc.Distinct())
            {
                Console.WriteLine(item);
            }
        }


        // just sorting it
        static void SoritItAlpha(ProductInfo[] prod)
        {
            // get names of prods, alphabetized
            //var subset = from p in prod orderby p.Name select p;
            var subset = from p in prod orderby p.Name descending select p; // Z-A sort
            Console.WriteLine("ordred by name: ");
            foreach (var item in subset)
            {
                Console.WriteLine(item.ToString());
            }
        }

        // reversing stuff
        static void ReverseStuff(ProductInfo[] prod)
        {
            Console.WriteLine("product in reverse");
            var allProducts = from p in prod
                              select p;
            foreach (var item in allProducts.Reverse())
            {
                Console.WriteLine(item.ToString());
            }
        }


        // getting counts with enumerable
        static void GetCountFromQuery()
        {
            string[] currentVGS = { "Morrowing", "System Shock 2", "Unch 2", "Crash 4", "Honk Time", "Gun Shoot 3" };
            // get count from the query
            int numbo = (from g in currentVGS where g.Length > 10 select g).Count();
            // print out the numbo of items
            Console.WriteLine(numbo + " item honor this linq query");

        }
        // getting projected stuff
        static Array GetProjectedSubset(ProductInfo[] prod)
        {
            var nameDesc = from p in prod select new { p.Name, p.Description };
            // map it all to an array
            return nameDesc.ToArray();
        }

        // Projecting new data types
        static void GetNamesAndDescs(ProductInfo[] prod)
        {
            Console.WriteLine("names and descs");
            var nameDesc = from p in prod select new { p.Name, p.Description };

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.GetType().Name);
            }

        }

        // gettinga  subset
        static void GetOverStock(ProductInfo[] prod)
        {
            Console.WriteLine("the overstock items");
            // get only itmes with more than 25 in stock
            var overstock = from p in prod where p.NumberInStock > 25 select p;
            foreach (var item in overstock)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void SelectEverything(ProductInfo[] products)
        {
            // get everythiiiing
            Console.WriteLine("all product details");
            var allProducts = from p in products select p;

            foreach (var prod in products)
                Console.WriteLine(prod.ToString());
        }

        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("onely product names");
            var names = from p in products select p.Name;
            foreach (var item in names)
            {
                Console.WriteLine("name: " + item);
            }
        }
    }

    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;

        public override string ToString()
            => $"Name={Name}, Descripttion={Description}, Number in stock={NumberInStock}";
    }
}
