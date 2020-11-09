using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public class FireSensor : IHazardSensor
    {

        public string Location;

        public FireSensor(string Location)
        {
            this.Location = Location;

        }
        public bool IsTriggered
        {
            get
            {
                //generating a random number between 1-20
                // 5% of the time it will be equal to 1 and will return true

                Random random = new Random();
                int randomNumber = random.Next(0, 21);
                if (randomNumber == 1) return true;
                else return false;
            }
            set { }
        }

        public string GetLocation()
        {
            return this.Location; // convention is to use the .NET class for properties/methods/constants
        }

        public string GetSensorType()
        {
            return this.GetType().ToString();
        }

        public double GetBatteryPercentage()
        {
            int batterUsed = 100 - (ControlUnit.pcount * 10);
            return batterUsed;
        }
    }
}
