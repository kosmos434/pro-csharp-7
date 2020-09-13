using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarForever
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a car.
            Car c = new Car();
            c.PetName = "carry";
            c.Speed = 44;
            c.Color = "red";


            // Car into garage.
            Garage g = new Garage();
            g.MyAuto = c;
        }
    }
}
