using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarForever
{
    class Garage
    {
        public int NumberOfCars { get; set; } = 1;

        // Careful here. Car's backing field is set to _null_!!
        public Car MyAuto { get; set; } = new Car();

    }
}
