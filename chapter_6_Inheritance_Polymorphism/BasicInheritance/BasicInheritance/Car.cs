﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        int currSpeed;

        public Car()
        {
            maxSpeed = 55;
        }
        public Car(int max)
        {
            maxSpeed = max;
        }

        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }


    }
}
