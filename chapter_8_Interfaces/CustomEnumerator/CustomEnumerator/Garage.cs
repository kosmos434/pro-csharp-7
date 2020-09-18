using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        // fill with some Car object on startup
        public Garage()
        {
            carArray[0] = new Car("Rusty", 20);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 90);
            carArray[3] = new Car("Feefee", 100);
        }

        public IEnumerator GetEnumerator()
        {
            // return the array object's IEnumerator
            return carArray.GetEnumerator();
        }
    }
}
