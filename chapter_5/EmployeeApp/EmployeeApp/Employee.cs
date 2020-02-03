using System;


namespace EmployeeApp
{
    class Employee
    {
        // field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN = "";



        // properties!!
        // the preferred way of getting and setting
        public int Age
        {
            //get { return empAge; }
            //set { empAge = value; }
            // or as expression-bodies member
            get => empAge;
            set => empAge = value;
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("error! that name-a too long *mario voice*");
                else
                    empName = value; // 'name'
            }
        }
        // the 'int' represents the type of data this property encapsulates
        // note the lack of parenthesis
        public int ID {
            get { return empID; }
            set { empID = value; }
        }
        // also note that 'value' is the contextual keyword
        // that represents the value assigned by the caller
        public float Pay {
            get { return currPay; }
            set { currPay = value; }
        }
        // note that this is READ-ONLY
        // no setter
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }



        // constructors
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



        // methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("name: {0}", Name);
            Console.WriteLine("id: {0}", ID);
            Console.WriteLine("age: {0}", Age);
            Console.WriteLine("pay: {0}", Pay);
        }




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
