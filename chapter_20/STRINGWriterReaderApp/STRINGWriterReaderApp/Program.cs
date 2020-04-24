using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace STRINGWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("........fun with stringwriter stringreader..........\n\n");

            // create a StringWriter and emit character data to memory
            using(StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget to do laundry");
                // get a copy of contents (stored in a string) and dump to console
                Console.WriteLine($"contents of stringwriter:\n{strWriter}");

                // get the internal stringbuilder
                Console.WriteLine("---messing with insert and remove---");
                StringBuilder sb = strWriter.GetStringBuilder();
                sb.Insert(0, "Hey there! ");
                Console.WriteLine($"----> {sb.ToString()}");
                sb.Remove(0, "Hey there! ".Length);
                Console.WriteLine($"----> {sb.ToString()}");


                // now we use StringReader
                using(StringReader strReader = new StringReader(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }


            }// end StringWriter

            Console.ReadLine();
        }
    }
}
