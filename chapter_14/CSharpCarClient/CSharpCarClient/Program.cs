using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar delorean = new SportsCar("delorean", 155, 88);
            delorean.TurboBoost();

            MiniVan mv = new MiniVan();
            mv.TurboBoost();
        }
    }
}
