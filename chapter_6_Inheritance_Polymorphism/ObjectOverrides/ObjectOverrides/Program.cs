using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();

            //// Use the inherited members of System.Object
            //Console.WriteLine($"tostring: {p1.ToString()}");
            //Console.WriteLine($"hash code {p1.GetHashCode()}");
            //Console.WriteLine($"type {p1.GetType()}");

            //// Other references to p1
            //Person p2 = p1;
            //object o = p2;
            //// Are the references pointing to the same object in memory??
            //if(o.Equals(p1) && p2.Equals(o))
            //    Console.WriteLine("same instance!!");


            // We want these identital to test Equals() and GetHashCode() methods
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);
            // Stringified version of these simps
            Console.WriteLine($"p1.tostring() = {p1.ToString()}");
            Console.WriteLine($"p2.tostring() = {p2.ToString()}");
            // test Equals()
            Console.WriteLine($"p1 = p2?? {p1.Equals(p2)}");
            // test hash codes
            Console.WriteLine($"same hash codes?? {p1.GetHashCode() == p2.GetHashCode()} ");

            // Change age of p2 and test once more
            p2.Age = 999;
            Console.WriteLine($"p1.tostring() = {p1.ToString()}");
            Console.WriteLine($"p2.tostring() = {p2.ToString()}");
            Console.WriteLine($"p1 = p2?? {p1.Equals(p2)}");
            Console.WriteLine($"same hash codes?? {p1.GetHashCode() == p2.GetHashCode()} ");

            StaticMembersOfObject();
        }

        static void StaticMembersOfObject()
        {
            // static members of System.Object
            Person p3 = new Person("hernk", "jones", 83);
            Person p4 = new Person("hernk", "jones", 83);
            Console.WriteLine($"p3 and p4 have te same state: {object.Equals(p3, p4)}");
            Console.WriteLine($"p3 and p4 are " +
                $"pointing to the same object: {object.ReferenceEquals(p3, p4)}");
        }
    }
}
