    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmApplicationOOP
{
   public class GSM
    {
        public static GSM IPhone4S = new GSM("IPhone 4S", "Apple", 500, "Telenor",
                                            new Battery("Apple", 8, 20, Battery.Type.LiIon),
                                            new Display(950, 16000000));
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        private List<Call> CallHistory;


        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.Append("GSM Specifications:");
            stringCreator.Append(" ");
            stringCreator.AppendLine(new string('-', 90));
            stringCreator.AppendFormat("GSM Model - {0}", this.Model);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Manufacturer - {0}", this.Manufacturer);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Price - {0}", this.Price);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Owner - {0}", this.Owner);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Battery Specifications : Model - {1} , Type - {0} , talk time - {2} , idle time - {3}"
                          , this.Battery.BatteryType, this.Battery.Model, this.Battery.HoursTalk, this.Battery.HoursIdle);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Display Specifications : Size - {0} , Number of Colors - {1}",
                            this.Display.Size, this.Display.NumberOfColors);
            stringCreator.AppendLine();
            stringCreator.AppendLine(new string('-', 110));

            return stringCreator.ToString();
        }

        public void AddCall(string currentPhoneNumber, long durationCall)
        {
            this.CallHistory.Add(new Call(currentPhoneNumber, durationCall));
        }

        public void DeleteCall(int position)
        {
            this.CallHistory.RemoveAt(position - 1);
        }

        public void DeleteAll()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalPriceCost(decimal callPricePerSecond)
        {
            long allDuration = 0;

            foreach(var call in CallHistory)
            {
                allDuration += call.Duration;
            }

            return allDuration * callPricePerSecond;
        }

        public void DisplayCallHistory()

        {
            if (!this.CallHistory.Any())
            {
                Console.WriteLine("List is empty");
            }

            foreach(var call in CallHistory)
            {
                Console.WriteLine("Call with number {0} with duration {1}", call.PhoneNumber, call.Duration);
            }
        }


    }
}
