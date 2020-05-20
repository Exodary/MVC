using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
    public class Battery
    {
        public enum Type
        {
            LiIon,
            NiMH,
            NiCd,
            LiPo,
            AlienTech
        }

        public string Model { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public Type batteryType;


        public Battery(string model, Type batteryType, int hoursIdle = 0, int hoursTalk = 0)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }
    } 
}
