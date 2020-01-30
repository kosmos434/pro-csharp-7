using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Process any incoming args
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);

            //foreach (string arg in args)
            //Console.WriteLine("Arrrrg: {0}", arg);

            // Get arguments using System.Environment
            //string[] theArgs = Environment.GetCommandLineArgs();
            //foreach (string arg in theArgs)
            //Console.WriteLine("Arg: {0}", arg);

            // Helper method within the Program class
            ShowEnvironmentDetails();

            // abitrary return code (-1 means fail usually)
            Console.ReadLine();
            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine
            // and other "interesting" details
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("driiive: {0}", drive);

            Console.WriteLine("os: {0}", Environment.OSVersion);
            Console.WriteLine("number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
            Console.WriteLine();
            Console.WriteLine("username: {0}", Environment.UserName);

        }
    }
}