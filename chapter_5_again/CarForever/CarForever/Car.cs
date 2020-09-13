using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarForever
{
    class Car
    {
        // Auto-props don't need a backing field.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        // Just type prop
        public int MyProperty { get; set; }
        public int MyReadOnlyProperty { get; }


    }
}
