using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
        partial class Employee
        {
            // Field data.
            string empName;
            int empID;
            float currPay;
            int empAge;
            string empSSN;

            // Properties.
            public string SocialSecurityNumber  // Read-only.
            {
                get { return empSSN; }
            }
            public string Name
            {
                get { return empName; }
                set
                {
                    if (value.Length > 15)
                        Console.WriteLine("too long");
                    else
                        empName = value;
                }
            }
            public int Age
            {
                get { return empAge; }
                set { empAge = value; }
            }

            public int ID
            {
                get { return empID; }
                set { empID = value; }
            }

            public float Pay
            {
                get { return currPay; }
                set { currPay = value; }
            }

            // Constructors.
            public Employee() { }
            public Employee(string name, float pay)
                : this(name, 0, pay) { }
            public Employee(string name, int id, float pay)
                : this(name, 0, id, pay) { }

            public Employee(string name, int age, int id, float pay)
            {
                Name = name;
                ID = id;
                Age = age;
                Pay = pay;
            }
        }
}
