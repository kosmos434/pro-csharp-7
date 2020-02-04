using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI = 3.14;

        // read-only fields can be assigned in ctors,
        // but nowhere else!
        //public readonly double PI;

        //public MyMathClass ()
        //{
        //    PI = 3.14;
        //}
    }
}
