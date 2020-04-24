using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....fun with binary writers / readers.......");

            // open a binary writer for a file
            FileInfo f = new FileInfo("BinFile.dat");
            using(BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                // print out the type of basestream
                // System.IO.FileStream in this case
                Console.WriteLine($"base stream is: {bw.BaseStream}");

                // create some data to save
                double aDouble = 1234.53;
                int anInt = 3333;
                string aString = "Howdy";

                // write data
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
            }

            // read the binary data from the stream
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }


            Console.WriteLine("-------Done------");
            Console.ReadLine();
        }
    }
}
