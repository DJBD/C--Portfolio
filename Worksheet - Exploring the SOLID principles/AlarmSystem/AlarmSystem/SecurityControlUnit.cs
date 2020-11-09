using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public class SecurityControlUnit: ControlUnit
    {
       private List<ISensor> sensors;

        internal SecurityControlUnit(List<ISensor> sensors) : base(sensors)
        {
            this.sensors = sensors;
        }

        public override void PollSensors()
        {    
          int currentTime = (DateTime.Now).Hour;           
          if (currentTime>=22 || currentTime<= 6) base.PollSensors();
        }


    }
}
