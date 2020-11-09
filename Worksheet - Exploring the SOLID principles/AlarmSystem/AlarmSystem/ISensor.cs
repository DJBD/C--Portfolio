using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
   public interface ISensor 
    {
        bool IsTriggered { get; set; }
        string GetLocation();
        string GetSensorType();

        //double GetBatteryPercentage(); by having this in the interface it would break the Liskov Principle when implementing Hazard sensors
    }
}
