using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public class SmokeSensor : IHazardSensor
    {
        public string Location { get; set; }


        public SmokeSensor(string Location)
        {
            this.Location = Location;
        }

        public bool IsTriggered
        {
            get
            {
                //generating a random number between 1-10
                // 10% of the time it will be equal to 1 and will return true

                Random random = new Random();
                int randomNumber = random.Next(0, 11);
                if (randomNumber == 1) return true;
                else return false;
            }
            set { }
        }

        public string GetLocation()
        {
            return this.Location; ;
        }

        public string GetSensorType()
        {
            return this.GetType().ToString();
        }

        public double GetBatteryPercentage()
        {
            int batterUsed = 100 - (ControlUnit.pcount * 20);
            return batterUsed;
        }
    }
}