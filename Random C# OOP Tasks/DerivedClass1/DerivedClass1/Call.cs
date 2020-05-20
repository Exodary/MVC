using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
    public class Call
    {
        public string PhoneNumber { get; set; }
        public int Duration { get; set; }
        public DateTime DateTime { get; private set; }

        public Call(string phoneNumber, int duration)
        {   
            this.DateTime = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.AppendFormat("{0} : Duaration - {1} , made on {2}", this.PhoneNumber, this.Duration, this.DateTime);
            stringCreator.AppendLine();
            return stringCreator.ToString();
        }
    }
}
