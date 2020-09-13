using System;
using System.Collections.Generic;
using System.Text;

namespace BasicInheritance
{
    sealed class Minivan : Car
    {

        public void TestMethod()
        {
            Speed = 10;
            // Can't access a parent private field.
            //currSpeed = 10;
        }
    }
}
