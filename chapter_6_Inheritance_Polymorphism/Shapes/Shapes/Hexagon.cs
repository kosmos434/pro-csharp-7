using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Hexagon : Shape
    {
        public Hexagon()
        {

        }

        public Hexagon(string name) :base(name)
        {

        }

        public override void Draw()
        {
            //Console.WriteLine($"drawing {PetName} the hexagon, yay. This is an overridden method" +
            //    $"when a parent class has a method marked virual, derived classes can optionally" +
            //    $"override it by useing the keyword override");

            Console.WriteLine($"drawing {PetName} the hexagon");
        }
    }
}
