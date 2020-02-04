using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; } = 1;

        // the hidden Car backing field is set to null!
        // the takeaway here is that auto-properties
        // don't work well with Class objects (null default)
        //public Car MyAuto { get; set; }

        // ... now it's set to a new object
        public Car MyAuto { get; set; } = new Car();

        // must use constructors to override default
        // values assigned to hidden backing fields
        //public Garage()
        //{
        //    MyAuto = new Car();
        //    NumberOfCars = 1;
        //}
        //public Garage(Car car, int number)
        //{
        //    MyAuto = car;
        //    NumberOfCars = number;
        //}

        // ... updated constructors
        public Garage() { }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
