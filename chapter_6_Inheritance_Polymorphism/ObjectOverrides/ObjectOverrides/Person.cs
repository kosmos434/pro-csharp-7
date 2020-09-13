using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOverrides
{
    class Person : Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString() =>
            $"[First name: {FirstName}; " +
            $"Last name: {LastName}; " +
            $"Age: {Age}]";

        //public override bool Equals(object obj)
        //{
        //    if(obj is Person && obj != null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if(temp.FirstName == this.FirstName
        //            && temp.LastName == this.LastName
        //            && temp.Age == this.Age)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}

        // no need to cast "obj" to a Person anymore,
        // as everything has a ToString() method.
        public override bool Equals(object obj) => obj?.ToString() == ToString();

        public override int GetHashCode() => ToString().GetHashCode();
    }
}
