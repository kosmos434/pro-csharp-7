using System;


namespace EmployeeApp
{
    partial class Employee
    {
        // field data!!
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN = "";







        // constructors!!
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }

        // master constructor!
        public Employee(string name, int age, int id, float pay)
        {
            // user Property names when assigning values
            // reduces the amount of duplicate error checks
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }// end constructors








        //// accessor (Getter method)
        //public string GetName()
        //{
        //    return empName;
        //}

        //// mutator (setter method)
        //public void SetName(string name)
        //{
        //    // do a check on incoming value
        //    // before making an assignment
        //    if (name.Length > 15)
        //        Console.WriteLine("error! that name-a too long *mario voice*");
        //    else
        //        empName = name;
        //}




    }// end class

}// end namespace
