using System;

namespace Properties
{
    class Car
    {
        // automatic properties!!
        public string PetName { get; set; }

        public int Speed { get; set; }
        public string Color { get; set; }

        // type 'prop' and tab to auto-
        // create an automatic property
        //public bool MyBool { get; set; }

        // make a read-only property by
        // leaving out the 'set;'
        //public int MyReadOnlyProp { get; }

        // class method
        public void DisplayStats()
        {
            Console.WriteLine("car name: {0}", PetName);
            Console.WriteLine("speed: {0}", Speed);
            Console.WriteLine("color: {0}", Color);
        }// end DisplayStats method
    }//end class
}// end namespace