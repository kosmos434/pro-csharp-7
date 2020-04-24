using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++fun with Directory(Info)+++\n");
            //ShowWindowsDirectoryInfo();
            //DisplayImageFiles();
            //ModifyappDirectory();
            //ModifyappDirectory2();
            //FunWithDirectoryType();
            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Help");
            Console.WriteLine("---Directory Info---");
            Console.WriteLine($"Fullname: {dir.FullName}");
            Console.WriteLine($"name: {dir.Name}");
            Console.WriteLine($"parent: {dir.Parent}");
            Console.WriteLine($"creation: {dir.CreationTime}");
            Console.WriteLine($"attrbutes: {dir.Attributes}");
            Console.WriteLine($"root: {dir.Root}");
            Console.WriteLine("------\n");
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            // get all files with the .jpg extension
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            // how many were found?
            Console.WriteLine($"Found {imageFiles.Length} jpg files\n");

            // now print out info for each file
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("------");
                Console.WriteLine($"File name: {f.Name}");
                Console.WriteLine($"file size: {f.Length}");
                Console.WriteLine($"creation time: {f.CreationTime}");
                Console.WriteLine($"attributes: {f.Attributes}");
                Console.WriteLine("------\n");
            }
        }

        static void ModifyappDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");

            // create MyFolder off application directory
            dir.CreateSubdirectory("MyFolder");

            // create MyFolder2 Data off application directory
            dir.CreateSubdirectory(@"MyFolder2\Data");
        }

        static void ModifyappDirectory2()
        {
            DirectoryInfo dir = new DirectoryInfo(".");

            // create MyFolder off initial directory
            dir.CreateSubdirectory("MyFolder");

            // Capture returned DirectoryInfo object
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");

            // prints path to ..\MyFolder2\Data
            Console.WriteLine($"New folder is {myDataFolder}");
        }

        static void FunWithDirectoryType()
        {
            // list all drives on computer
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("heres the drives");
            foreach (string s in drives)
            {
                Console.WriteLine($"--> {s}");
            }

            // delete the prev created folders
            Console.WriteLine("press enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\MyFolder");

                // the second parameter specifies whether you wish
                // to destory subdirectories
                Directory.Delete(@"C:\MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
