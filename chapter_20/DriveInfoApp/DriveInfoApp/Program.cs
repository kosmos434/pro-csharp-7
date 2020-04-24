using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---fun with DriveInfo---");

            // get infor regarding all drives
            DriveInfo[] myDrives = DriveInfo.GetDrives();

            // print those dirves
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine($"name: {d.Name}");
                Console.WriteLine($"type: {d.DriveType}");

                // check whether drive is mounted
                if (d.IsReady)
                {
                    Console.WriteLine($"free space: {d.TotalFreeSpace}");
                    Console.WriteLine($"format: {d.DriveFormat}");
                    Console.WriteLine($"label: {d.VolumeLabel}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
