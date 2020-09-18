using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
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

            // iterator method
        public IEnumerator GetEnumerator()
        {
            // this will not get thrown until MoveNext() is called
            //throw new Exception("This will get called");

            return actualImplementation();


            // this is a private function
            // a function within another function and it's private!!
            IEnumerator actualImplementation()
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }

        public IEnumerable GetTheCars(bool returnReversed)
        {
            // do some error checking here
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                // return items in reverse!!
                if (returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    // return the items as placed in the array
                    foreach (Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }


    }
}
