using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- fun with FileStreams ----");

            // obtain a FileStream object
            using(FileStream fStream = File.Open(@"myMessage.Dat",
                FileMode.Create))
            {
                // encode a string as an array of bytes
                string msg = "Howdy partner";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                // write byte[] to file
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                // read internal position of stream
                fStream.Position = 0;

                // read the types from file and display to console
                Console.WriteLine("You message---in array of byte form!");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                    Console.Write(" ");
                }

                // display decoded messages
                Console.Write("\nDecoded message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }

            Console.ReadLine();
        }
    }
}
