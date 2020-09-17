using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // call rom the object level
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 140);
            myBitmap.DrawUpsideDown();


            // or call IAdvancedDraw explicitly
            IAdvancedDraw iAdv = myBitmap as IAdvancedDraw;
            if (iAdv != null)
                iAdv.DrawUpsideDown();


            Console.ReadLine();
        }
    }
}
