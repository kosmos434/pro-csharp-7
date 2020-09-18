using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Car
    {
        // constant for max speed
        public const int MaxSpeed = 100;

        // car properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // is the car still working?
        private bool carIsDead;

        // a car has a radio
        private Radio theMusicBox = new Radio();

        // constructors
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
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
    }
}
