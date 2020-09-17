using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            
            Octagon oct = new Octagon();


            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            // shorthand
            ((IDrawToPrinter)oct).Draw();

            // use "as" instead
            if (oct is IDrawToMemory dtm)
            {
                dtm.Draw();
            }


            //IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            //itfPrinter.Draw();

            //IDrawToMemory itfMemory = (IDrawToMemory)oct;
            //itfMemory.Draw();

            Console.ReadLine();

        }
    }
}
