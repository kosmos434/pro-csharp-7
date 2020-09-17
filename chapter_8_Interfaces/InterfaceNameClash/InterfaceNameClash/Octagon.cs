using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    // shared drawering logic
        //    Console.WriteLine("drawing the humble octagon, the beautiful 8-sided shape");

        //}

       // Explicitly bind Draw()'s to a give interface
       void IDrawToForm.Draw()  // explicitly binded members are private implicitly
        {
            Console.WriteLine("Drawin to form");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawin to Memory");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawin to Printer");
        }
    }
}
