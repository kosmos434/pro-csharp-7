using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        // Hiding an inherited property
        public new string PetName { get; set; }

        // Shadowing--overriding when you don't share a namespace
        public new void Draw()
        {
            Console.WriteLine("Drawing 3d circle, yay");
        }
    }
}
