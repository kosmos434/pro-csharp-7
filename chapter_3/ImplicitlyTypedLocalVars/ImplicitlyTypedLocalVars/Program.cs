using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {

        static void Main(string[] args)
        {
            DeclareImplicitVars();
            Console.ReadLine();
        }


        static void DeclareImplicitVars()
        {
            // implicitly typed local variables
            // simply type
            // var identifierName = intitialValue;
            var myInt = 0;
            var myBool = true;
            var myString = "This... is a string..";

            // print out the underlying type..
            Console.WriteLine("myInt is a {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a {0}", myString.GetType().Name);
        }

        static void ImplicitTypingIsStrongTyping()
        {
            // the compiler knows "s" is a System.STring
            var s = "This variable can hold any string data..";
            s = "No problem here";

            // Can invoke any member of the underlying type
            string upper = s.ToUpper();

            // Error! Cant assign numerical data to a strin
            s = 44;


        }
    }
}
