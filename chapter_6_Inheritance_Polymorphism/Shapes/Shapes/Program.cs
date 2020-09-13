using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hexagon hx = new Hexagon("Gonny");
            //Hexagon hx2 = new Hexagon();
            //hx2.Draw();


            //Circle crcl = new Circle("Circley");
            //crcl.Draw();

            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Ralph"),
                new Circle("Circky"), new Hexagon("Henk")};

            // Loop over each item and do a thing
            foreach (Shape shape in myShapes)
            {
                shape.Draw();
            }
	            
        }
    }
}
