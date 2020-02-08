using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmApplicationOOP
{
   public class Battery
    {
        public string Model { get; set; }
        public int HoursTalk { get; set; }
        public int HoursIdle { get; set; }
        public Type BatteryType { get; set; }

       public enum Type
        {
            LiIon,
            NiMH,
            NiCd
        }

        public Battery(string model, int hoursTalk, int hoursIdle, Type batteryType)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
            this.BatteryType = batteryType;
        }

        
    }
}
