using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDirectoryWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish the path to the directory to watch
            FileSystemWatcher watcher = new FileSystemWatcher();

            try
            {
                watcher.Path = @"C:\MyFolder";
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                return;
            }

            // set up things to lookout for
            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            // only the txt files
            watcher.Filter = "*.txt";

            // Specify what is done when a file is changed, created, or deleted.
            watcher.Changed += (s, e) =>
            {
                Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
            };

            watcher.Created += (s, e) =>
            {
                Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
            };

            watcher.Deleted += (s, e) =>
            {
                Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
            };

            watcher.Renamed += (s, e) =>
            {
                // Specify what is done when a file is renamed.
                Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            };

            // Begin watching the directory.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine(@"Press 'q' to quit app.");
            while (Console.Read() != 'q') ;
        }
    }
}
