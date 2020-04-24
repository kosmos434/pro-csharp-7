using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWritrerReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== fun with StreamWriter and StreamReader ===");

            // get a StreamWriter and write string data
            //using (StreamWriter writer = File.CreateText("reminders.txt"))
            using (StreamWriter writer = new StreamWriter("reminders.txt"))
            {
                writer.WriteLine("Don't forget to get coookies.");
                writer.WriteLine("Don't forget to get apples.");
                writer.WriteLine("Don't forget these simple numbers...");
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + " ");
                }

                // insert a new line
                writer.Write(writer.NewLine);
            }
            Console.WriteLine("---reminder text file created---\n\n");

            // now read data from the file
            Console.WriteLine("here are the reminders");
            //using(StreamReader sr = File.OpenText("reminders.txt"))
            using (StreamReader sr = new StreamReader("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            
            Console.ReadLine();
        }
    }
}
