using System;
using MyShapes;
using The3DCircle = Chapter14.My3DShapes.Circle;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MyShapes.Hexagon h = new Hexagon();
            Circle c = new Circle();
            Square s = new Square();

            // This is a cirlce from 3d cirlce stuff.
            The3DCircle c2 = new The3DCircle();
        }

    } 
}
