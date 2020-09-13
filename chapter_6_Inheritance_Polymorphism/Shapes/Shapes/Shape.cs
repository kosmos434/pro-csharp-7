using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        public string PetName { get; set; }

        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        // Single virtual method
        //public virtual void Draw()
        //{
        //    Console.WriteLine("inside Shape.Draw()");
        //}

        public abstract void Draw();
        // Note the semicolon for an abstract method.
        // Abstract methods are just an outline that MUST be implemented
        // in a derived class.
    }
}
