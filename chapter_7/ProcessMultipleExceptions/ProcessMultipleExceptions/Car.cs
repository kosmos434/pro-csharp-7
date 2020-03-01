using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions

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
            if (delta < 0)
                throw new
                    ArgumentOutOfRangeException("delta", "Speed must be greater than zero, my dude");

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
                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated", 
                        "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.auto-comrade-fake.ru";
                    throw ex;
                }
                else
                    Console.WriteLine($"==> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
