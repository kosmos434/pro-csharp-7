using System;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Points using ints
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine($"p.toString()={p.ToString()}");
            p.ResetPoint();
            Console.WriteLine($"p.toString()={p.ToString()}");
            Console.WriteLine();

            // and using double
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine($"p2.toString()={p2.ToString()}");
            p2.ResetPoint();
            Console.WriteLine($"p2.toString()={p2.ToString()}");
            Console.WriteLine();
            // nice 😎

        }
    }
}





/// <summary>
/// generic as h*ck struct
/// </summary>
/// <typeparam name="T"></typeparam>
public struct Point<T>
{
    // Generic properties 
    public T X { get; set; }
    public T Y { get; set; }

    // Generic constructor.
    public Point(T xVal, T yVal)
    {
        X = xVal;
        Y = yVal;
    }

    public override string ToString() => $"[{X}, {Y}]";

    // The default keyword is overloaded in c#
    // WHen used with generics it represents the default value of a type parameter
    // Reset fields to the default value of the
    // type parameter.
    public void ResetPoint()
    {
        X = default(T);
        Y = default(T);
    }
}