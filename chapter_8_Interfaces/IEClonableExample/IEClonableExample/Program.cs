using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEClonableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // These classes support the ICloneable interface
            string myStr = "Howdy";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn =
                new System.Data.SqlClient.SqlConnection();

            // ...so they can all be passed into a method taking ICloneable
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            var strClone = myStr.Clone();
            Console.WriteLine(strClone.GetType().FullName);
            Console.ReadLine();

        }

        // CloneMe method
        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine($"Your clone is a {theClone.GetType().Name}");
        }

    }
}
