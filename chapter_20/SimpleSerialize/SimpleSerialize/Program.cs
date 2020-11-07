using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SimpleSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...........fun with serialization............");

            // make a car and set state
            JamesBondCar hbc = new JamesBondCar();
            hbc.canFly = true;
            hbc.canSubmerge = false;
            hbc.theRadio.stationPresets = new double[] { 55.3, 66.6, 66.2 };
            hbc.theRadio.hasTweeters = true;

            // and save it to a specifi file in a binary format
            SaveAsBinaryFormat(hbc, "CarData.dat");
            LoadFromBinaryFormat("CarData.dat");
            SaveAsSOAPFormat(hbc, "CarData.soap");
            SaveAsXMLFormat(hbc, "CarData.xml");
            SaveListOfCars();
            SaveListOfCarsAsBinary();




            Console.ReadLine();
        }

        static void SaveListOfCarsAsBinary()
        {
            // save arrayList obj (myCars) as binary
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("AllMyCars.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("sae list of cars in binary format yay");
        }

        static void SaveListOfCars()
        {
            // persists  a List<T> of JameBonscars
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            myCars.Add(new JamesBondCar(true, true));
            myCars.Add(new JamesBondCar(false, true));
            myCars.Add(new JamesBondCar(true, false));
            myCars.Add(new JamesBondCar(false, false));
            myCars.Add(new JamesBondCar(true, true));

            using (Stream fStream = new FileStream("CarCollection.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
                xmlFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("save a list of cars into xml yay");
        }

        static void SaveAsXMLFormat(object objGraph, string fileName)
        {
            // savve obj to a file named CarData.xml in XML format
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));

            using (Stream fStream = new FileStream(fileName, FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("save care in xml format yay");
        }

        static void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            // save obj to a file named CarData.dat in binary
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = new FileStream(fileName,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("saved car in binary format yay");
        }

        static void SaveAsSOAPFormat(object objGraph, string fileName)
        {
            // save obj to a file named CarData.dat in binary
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream(fileName,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("saved car in SOAP format yay");
        }

        static void LoadFromBinaryFormat(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            // read the JameBonDcar from the binary file
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk =
                    (JamesBondCar)binFormat.Deserialize(fStream);
                Console.WriteLine($"can this car fly?? ---> {carFromDisk.canFly}");
            }
        }
    }

    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubwoofers;
        public double[] stationPresets;

        [NonSerialized]
        public string radioID = "ZZ-69420";
    }

    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }

    [Serializable, XmlRoot(Namespace = "http://www.fake.com")]
    public class JamesBondCar : Car
    {
        public JamesBondCar(bool skyWorthy, bool seaWorthy)
        {
            canFly = skyWorthy;
            canSubmerge = seaWorthy;
        }
        public JamesBondCar()
        {
            // default ctor, which is required by XmlSerializer
        }
        [XmlAttribute]
        public bool canFly;
        [XmlAttribute]
        public bool canSubmerge;
    }
}
