using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensors = new List<ISensor>();

            sensors.Add(SensorFactory.NewFireSensor("Lobby"));
            sensors.Add(SensorFactory.NewSmokeSensor("Bedroom"));
            sensors.Add(SensorFactory.NewMotionSensor("Bathroom"));

            var hazsensors = new List<ISensor>();
            var secsensors = new List<ISensor>();

            foreach (ISensor sensor in sensors)
            {
                if (sensor is IHazardSensor) hazsensors.Add(sensor);
                else secsensors.Add(sensor);
            }

            IControlUnit controlUnit = new ControlUnit(hazsensors);
            IControlUnit securityUnit = new SecurityControlUnit(secsensors);


            string input = string.Empty;
            while (!input.Equals("exit"))
            {
                Console.WriteLine("Type \"poll\" to poll all sensors once or \"exit\" to exit");
                input = Console.ReadLine();
                if (input.Equals("poll"))
                {
                    controlUnit.PollSensors();
                    securityUnit.PollSensors();
                }
            }
        }
    }
}