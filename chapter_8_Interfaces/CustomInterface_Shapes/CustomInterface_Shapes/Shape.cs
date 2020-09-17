using System;
using System.Collections.Generic;
using System.Text;

namespace CustomInterface_Shapes
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        // Force all child classes to define how to be rendered.
        public abstract void Draw();
    }

    #region Circle class
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
    #endregion

    #region Hexagon class 
    class Hexagon : Shape, IPointy, IDraw3
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        // Implementing IPointy too
        public byte Points
        {
            get { return 6; }
        }

        // and the 3D draw method, from the IDraw interface
        public void Draw3D()
        {
            Console.WriteLine("Drawing a hexagon in 3d!!");
        }
    }
    #endregion

    #region 3D circle
    class ThreeDCircle : Circle, IDraw3
    {
        // Hide the PetName property above me.
        public new string PetName { get; set; }

        // Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        public void Draw3D()
        {
            Console.WriteLine("DRawing cirlce in 3d!!");
        }
    }
    #endregion
}
