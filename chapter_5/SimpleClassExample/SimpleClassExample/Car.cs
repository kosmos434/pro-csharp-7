using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // the 'state' of the Car
        // field data really shouldn't be public
        public string petName;
        public int currSpeed;

        // a custom default Constructor
        // now all Cars begin life named "Faulty" and 0 MPH
        public Car()
        {
            petName = "Faulty";
            currSpeed = 2;
        }

        // custom constructors!!
        //public Car(string pn)
        //{
        //    petName = pn;
        //}
        // written differently
        // here, currSpeed will receive the
        // default value of an int (zero 0)
        // this works only for one line methods,
        // so the twofer constructor is out
        public Car(string pn) => petName = pn;


        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

  

        // the functionality of Car
        // methods that model its behavior
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }// end class
}// end namespace
