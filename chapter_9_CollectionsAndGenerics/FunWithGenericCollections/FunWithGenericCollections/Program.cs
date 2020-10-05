using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            //UseGenericStack();
            //UseGenericQueue();
            //UseSortedSet();
            UseDictionary();
            Console.WriteLine();
        }


        /// <summary>
        /// dictionary like pyton. keys and values
        /// </summary>
        private static void UseDictionary()
        {
            // populate using Add() method
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Fomer", new Person {FirstName = "Fomer", LastName = "Simpson", Age = 12});
            peopleA.Add("Romer", new Person { FirstName = "Romer", LastName = "Simpson", Age = 423 });
            peopleA.Add("Loamer", new Person { FirstName = "Loamer", LastName = "Simpson", Age = 2856 });

            // get Fomer
            Person fomer = peopleA["Fomer"];
            Console.WriteLine(fomer);

            // now populate with collection init syntax
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Yomer", new Person {FirstName = "Yomer", LastName = "Simpson", Age = 3423} },
                {"Momer", new Person {FirstName = "Momer", LastName = "Simpson", Age = 1234} },
                { "Nomer", new Person {FirstName = "Nomer", LastName = "Simpson", Age = 99999} }
            };

            // get "Nomer"
            Person nomer = peopleB["Nomer"];
            Console.WriteLine(nomer);
        }



        /// <summary>
        /// auto sorts a set when removing or inserting
        /// </summary>
        static void UseSortedSet()
        {
            // ppl of diff ages
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person { FirstName = "Fomer", LastName = "Simpson", Age = 2236 },
                new Person { FirstName = "Gromer", LastName = "Simpson", Age = 43224 },
                new Person { FirstName = "Dwomer", LastName = "Simpson", Age = 324 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };

            // note the items are sorted by age!
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // add some more ppl, why not
            setOfPeople.Add(new Person { FirstName = "Aomer", LastName = "Simpson", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Zomer", LastName = "Simpson", Age = 99999 });

            // still sortef by age, the magic of SortedSet
            foreach (var p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }


        /// <summary>
        /// queue helper method
        /// </summary>
        static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.FirstName} got some yummy coffee");
        }

        /// <summary>
        /// queue method
        /// </summary>
        static void UseGenericQueue()
        {
            // mae a queue with 3 people
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Fomer", LastName = "Simpson", Age = 24 });
            peopleQ.Enqueue(new Person { FirstName = "Zomer", LastName = "Blinson", Age = 234 });
            peopleQ.Enqueue(new Person { FirstName = "Chomer", LastName = "Frenkin", Age = 634 });

            // peek at hte 1st peerosn
            Console.WriteLine($"{peopleQ.Peek()} is the first in line!");

            // remove some peeps
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            // try-ing again
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine("nah, not this time: " + ex.Message);
            }
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 44 });
            stackOfPeople.Push(new Person { FirstName = "Bromer", LastName = "Dimpson", Age = 34 });
            stackOfPeople.Push(new Person { FirstName = "Klomer", LastName = "Sampson", Age = 64 });

            // pop the top item out
            Console.WriteLine($"the first person is {stackOfPeople.Peek()}");
            Console.WriteLine("popping it off is " + stackOfPeople.Pop());
            Console.WriteLine("\n first person now is: " + stackOfPeople.Peek());
            Console.WriteLine("popping it off is " + stackOfPeople.Pop());
            Console.WriteLine("\n first person now is: " + stackOfPeople.Peek());
            Console.WriteLine("popping it off is " + stackOfPeople.Pop());

            try
            {
                Console.WriteLine("try-ing again");
                Console.WriteLine("\n first person now is: " + stackOfPeople.Peek());
                Console.WriteLine("popping it off is " + stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine("\n error here: " + ex.Message);
            }
        }

        static void UseGenericList()
        {
            // make a list of Perons object, filled with 
            // colleciton/object init syntax
            List<Person> people = new List<Person>()
            {
                new Person{FirstName = "Homer", LastName="Simpson", Age=44},
                new Person{FirstName = "Bomer", LastName="Simpson", Age=4234444},
                new Person{FirstName = "Jomer", LastName="Simpson", Age=444434}
            };

            // print out the num of items in the List
            Console.WriteLine("perople in the list: " + people.Count);

            // go thru list and print
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // add a new person
            Console.WriteLine("\n adding new perosn.");
            people.Insert(2, new Person { FirstName = "maggie", LastName = "simpsoins", Age = 3 });
            Console.WriteLine("perople in the list now: " + people.Count);

            // copy data into a new array
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("first names {0}", p.FirstName);
            }

        }
    }
}

class SortPeopleByAge : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        if (firstPerson?.Age > secondPerson?.Age)
        {
            return 1;
        }
        if (firstPerson?.Age < secondPerson?.Age)
        {
            return -1;
        }
        return 0;
    }
}



// yoinked from github
public class Person
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person() { }
    public Person(string firstName, string lastName, int age)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
