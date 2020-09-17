using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface_Shapes
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"drawing {PetName} the triangle");
        }

        // Now implement IPointy
        public byte Points
        {
            get { return 3; }
        }
    }
}
