using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        // field variables
        public int driverIntensity;
        public string driverName;
        //public string name;


        // constructors
        // put back the default constructor, which will
        // set all data members to default values
        //public Motorcycle() { }

        //// our custom constructor
        //public Motorcycle(int intensity)
        //{
        //    SetIntensity(intensity);
        //}

        //public Motorcycle(int intensity, string name)
        //{
        //    SetIntensity(intensity);
        //    driverName = name;
        //}



        // new and improved 'chained' constructors
        //public Motorcycle()
        //{
        //    Console.WriteLine("in default ctor");
        //}
        //public Motorcycle(int intensity)
        //    : this(intensity, "") {
        //    Console.WriteLine("in ctor taking in an int only");
        //}
        //public Motorcycle(string name)
        //    : this(0, name)
        //{
        //    Console.WriteLine("in ctor taking in string only");
        //}

        //// the 'master' constructor that does all the real work
        //public Motorcycle(int intensity, string name)
        //{
        //    Console.WriteLine("in 'master' ctor");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}



        // even better with optional parameters
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }






        // type 'ctor' to autocomplete a constructor
        //public Motorcycle()
        //{

        //}



        // new members to represent the name of the driver
        // note that we use 'this.name' to avoid ambiguity
        // ..but we could just use better parameter names
        public void SetDriverName(string name)
        {
            // these two statements are functionally the same
            driverName = name;
            //this.name = name;
        }// end method

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yippeeee ki-yay!");
            }
        }// end method


        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }









    }// end class
}// end namespace
