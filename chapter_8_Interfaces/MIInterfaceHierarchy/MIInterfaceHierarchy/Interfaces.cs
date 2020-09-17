using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IDrawable
    {
        void Draw();
    }

    interface IPrintable
    {
        void Print();
        void Draw(); // name clash possible, gotta be explicit
    }

    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
