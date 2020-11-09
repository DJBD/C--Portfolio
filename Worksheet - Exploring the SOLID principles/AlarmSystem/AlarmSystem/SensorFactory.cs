using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public static class  SensorFactory

    {
        public static ISensor NewSmokeSensor(String Location)
        {
            return new SmokeSensor(Location);
        }

        public static ISensor NewFireSensor(String Location)
        {
            return new FireSensor(Location);
        }

        public static ISensor NewMotionSensor(String Location)
        { 
            return new MotionSensor(Location);
        }



    }
}
