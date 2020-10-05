using System;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with generic methods!");

            // swap 2 ints
            int a = 10, b = 99;
            Console.WriteLine($"before swap {a} {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"after swap {a} {b}");
            Console.WriteLine();

            // now 2 strings
            string s1 = "hi", s2 = "bye";
            Console.WriteLine($"before swap {s1} {s2}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"after swap {s1} {s2}");
            Console.WriteLine();


            // Compiler will infer System.Boolean
            bool b1 = true, b2 = false;
            Console.WriteLine($"before swap {b1} {b2}");
            // object type is inferred, <bool> not needed
            Swap(ref b1, ref b2);
            Console.WriteLine($"after swap {b1} {b2}");



            // must supply type parameter if the method
            // does not take params
            DisplayBaseClass<int>();
            DisplayBaseClass<string>();

            // compiler erroe! now params? must supply placeholder


        }


        static void DisplayBaseClass<T>()
        {
            // basetype is a method used in reflection
            // honk honk
            Console.WriteLine($"base class of {typeof(T)} is: {typeof(T).BaseType}");
        }

        // this method will swap any two items. any!
        // with generics!!
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"you sent Swap method a {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }

        // yuck
        // swap two integers
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // swap two Person objects
        static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b;
            b = temp;
        }
    }
}







#region person class
public class Person
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person() { }
    public Person(string firstName, string lastName, int age)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
} 
#endregion