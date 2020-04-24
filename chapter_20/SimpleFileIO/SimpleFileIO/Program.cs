using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Simple I/O with the File type ------");

            string[] myTasks = {"Fix sink", "Call Cal",
                "Call Butt", "Play chess"};

            // write out all data to file on C drive
            File.WriteAllLines(@"tasks.txt", myTasks);

            // read it all back and print it out
            foreach (string task in File.ReadAllLines(@"tasks.txt"))
            {
                Console.WriteLine($"TODO: {task}");
            }

            Console.ReadLine();
        }
    }
}
