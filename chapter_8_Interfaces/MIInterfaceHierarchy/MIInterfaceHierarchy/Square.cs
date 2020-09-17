using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        // using explicit implementation to handle member naame clash
        void IPrintable.Draw()
        {
            ///drawing
        }
        void IDrawable.Draw()
        {
            /// draring
        }
       public void Print()
        {
            //printing
        }
        public int GetNumberOfSides() { return 4; }
    }
}
