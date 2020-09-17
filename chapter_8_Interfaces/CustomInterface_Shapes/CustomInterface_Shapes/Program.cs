using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hexagon hx = new Hexagon();
            //Console.WriteLine(hx.Points);
            //Console.ReadLine();

            //Circle cc = new Circle("Circo");
            //IPointy itfPt = null;
            //try
            //{
            //    itfPt = (IPointy)cc;
            //    Console.WriteLine(itfPt.Points);
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // ...but can we treat a hexagon as an IPointy?
            //Hexagon hex2 = new Hexagon("Hexo");
            //IPointy itfPt2 = hex2 as IPointy; // 'as' is better than cast-try-catch, make null if not poss

            //if(itfPt2 != null)
            //    Console.WriteLine("hex points: " + itfPt2.Points);
            //else
            //    Console.WriteLine("not a pointy..");



            //Make an array of shapes
           Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                // Shape has a draw abstract method
                myShapes[i].Draw();

                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("=> Points: " + ip.Points);
                else
                    Console.WriteLine(myShapes[i].PetName + " is not pointy");


                // now for a 3d check
                if (myShapes[i] is IDraw3)
                    DrawIn3D((IDraw3)myShapes[i]);
                Console.WriteLine();
            }



            Console.ReadLine();
        }


        static void DrawIn3D(IDraw3 itf3d)
        {
            Console.WriteLine("ddrawing IDraw3D compatible type below");
            itf3d.Draw3D();
        }
    }
}
