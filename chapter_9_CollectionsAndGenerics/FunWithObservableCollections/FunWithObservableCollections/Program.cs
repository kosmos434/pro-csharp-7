using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace FunWithObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a collection to observe and add a few Person objects
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{FirstName="Peter", LastName="Griffin", Age=33},
                new Person{FirstName="Lois", LastName="Griffin", Age=234}
            };

            // wire up the CollectionChanged event
            people.CollectionChanged += people_CollectionChanged;

            // print the items
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            // add and remvoe an item
            people.Add(new Person { FirstName = "Jeter", LastName = "Griffin", Age = 453 });
            people.RemoveAt(0);
        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // what was the action that caused the event?
            Console.WriteLine("action for this event " + e.Action);

            // they removed somethign
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("here are the old items");
                foreach (Person person in e.OldItems)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine();
            }

            // or they added something
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // now show the NEW items that were inserted
                Console.WriteLine("here are the new items");
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}





#region Person class for testing
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
#endregion