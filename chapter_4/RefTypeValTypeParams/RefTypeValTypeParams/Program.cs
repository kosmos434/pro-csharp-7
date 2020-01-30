using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // passing ref-types by value
            //Console.WriteLine("***** passing Person object by value ********");
            //Person geoff = new Person("Geoff", 22);
            //Console.WriteLine("\nbefore by value call, Person is:");
            //geoff.Display();

            //SendAPersonByValue(geoff);
            //Console.WriteLine("\nafter by value call, Person is:");
            //geoff.Display();

            Console.WriteLine("***** passing Person object by REFERENCE ********");

            Person mel = new Person("mel", 25);
            Console.WriteLine("before by value call, Person is: ");
            mel.Display();

            SendAPersonByReference(ref mel);
            Console.WriteLine("after by value call, Person is: ");
            mel.Display();

            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            // change the age of "p" ??
            p.personAge = 99;

            // will the caller see this reassignment??
            p = new Person("Nickenzie", 88);
        }

        static void SendAPersonByReference(ref Person p)
        {
            // change some data of 'p'
            p.personAge = 555;

            // 'p' is now pointing to a new object on the heap!
            p = new Person("Dickenzie", 007);
        }
    }

    class Person
    {
        public string personName;
        public int personAge;

        // constructors
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person() {}

        public void Display()
        {
            Console.WriteLine("name: {0}, age: {1}", personName, personAge);
        }
    }
}
