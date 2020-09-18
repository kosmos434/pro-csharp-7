using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparableCar
{
    class Car : IComparable
    {
        // constant for max speed
        public const int MaxSpeed = 100;

        // car properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }
        public static IComparer SortByPetname { get { return (IComparer)new PetNameComparerizer(); } }

        // is the car still working?
        private bool carIsDead;

        // a car has a radio
        private Radio theMusicBox = new Radio();

        // constructors
        public Car() { }
        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }

        // methods
        public void CrankTunes(bool state)
        {
            // delegate request to innner object
            theMusicBox.TurnOn(state);
        }

        // throw an exception if the user speeds up beyond MaxSpeed
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order..");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    // we need to call the HelpLink property, so we
                    // create a local variable before throwing the exception object
                    Exception ex = new Exception($"{PetName} has overheated");
                    ex.HelpLink = "http://www.auto-comrade-fake.ru";

                    // stuff in custom data regarding the error
                    ex.Data.Add("TimeStamp", $"the car exploded at {DateTime.Now}");
                    ex.Data.Add("Cause", "You put the pedal to the metal... too much.");
                    throw ex;

                    // use 'throw' keyword to raise an exception
                    //throw new Exception($"{PetName} has overheated!!");
                }
                else
                    Console.WriteLine($"==> CurrentSpeed = {CurrentSpeed}");
            }
        }

        // Icomparable implementation
        int IComparable.CompareTo(object obj)
        {
            //Car temp = obj as Car;
            //if (temp != null)
            //{
            //    if (this.CarID > temp.CarID)
            //        return 1;
            //    if (this.CarID < temp.CarID)
            //        return -1;
            //    else
            //        return 0;
            //}
            //else
            //    throw new ArgumentException("Parameter is not a car!!");

            // or better yet...
            Car temp = obj as Car;
            if (temp != null)
                return this.CarID.CompareTo(temp.CarID);
            else
                throw new ArgumentException("not a car etc");
        }
    }
}
