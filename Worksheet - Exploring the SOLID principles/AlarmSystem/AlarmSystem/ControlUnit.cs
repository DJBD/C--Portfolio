using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    public class ControlUnit : IControlUnit
    {
        private List<ISensor> sensors;
        public static int pcount;
        public Func<int,int> inc = pollCount();

        internal ControlUnit(List<ISensor> sensors)
        {
            this.sensors = sensors;
        }

        
        public virtual void PollSensors()
        {
            int pcount1 = inc(0);
            Console.WriteLine(pcount1);
            pcount = pcount1;

            foreach (ISensor sensor in sensors)
            {
                if (sensor is IHazardSensor Haz && Haz.GetBatteryPercentage() < 0)
                    Console.WriteLine($"Battery for {sensor.GetSensorType()} at {sensor.GetLocation()} is dead");

                else if (sensor.IsTriggered)
                {
                    Console.WriteLine(
                        "A " + sensor.GetSensorType() + " sensor was triggered at " + sensor.GetLocation());
                }

                else

                {
                    Console.WriteLine("Polled " + sensor.GetSensorType() + " at " + sensor.GetLocation() +
                                      " successfully");
                }
            }
        }

        static Func<int,int> pollCount()
            {
                var myVar = 0;
                Func<int, int> inc = (int var1) =>
                {
                    myVar = myVar + 1;
                    return var1 + myVar;
                };
                return inc;
            }


        
    }


}



