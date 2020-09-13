using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesRevenge
{
    abstract partial class Employee
    {
        // Field data.
        string empName;
        int empID;
        float currPay;
        int empAge;
        string empSSN;

        #region Properties.
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
        #endregion

        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        public Employee(string name, int age, int id, float pay, string ssn)
            :this(name, age, id, pay)
        {
            empSSN = ssn;
        }

        // Contain a BenefitPackage object
        protected BenefitsPackage empBenefits = new BenefitsPackage();

        // Expose method from the "has-a" class
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        // and expose fields.
        public BenefitsPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
    }
}
