using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
    public class GSM
    {
        public static GSM IPhone4S = new GSM("IPhone 4S", "Apple",
                                                        new Battery("Apple", Battery.Type.LiPo, 8, 200),
                                                        new Display(960, 640, 16000000)
                                                        , 1300.00m, "Telenor");

        public const decimal CallPricePerSecond = 0.37m;
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery battery;
        public Display display;

        public List<Call> CallHistory;

        public GSM(string model, string manufacturer, Battery battery,
            Display display, decimal price = 0, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
            this.CallHistory = new List<Call>();
        }

        public void AddCall(string number, int duration)
        {
            CallHistory.Add(new Call(number, duration));
        }

        public void DeleteCall(int position)
        {
            CallHistory.RemoveAt(position);
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateTotalPrice()
        {
            var totalDuration = 0;

            foreach(var call in CallHistory)
            {
                totalDuration += call.Duration;
            }

            var priceToPay = totalDuration * CallPricePerSecond;

           return priceToPay;
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:");
            int indexer = 0;
            foreach (var call in this.CallHistory)
            {
                Console.Write(indexer++);
                Console.Write(" ---> ");
                Console.WriteLine(call.ToString());
            }
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
                          , this.battery.batteryType, this.battery.Model, this.battery.HoursTalk, this.battery.HoursIdle);
            stringCreator.AppendLine();
            stringCreator.AppendFormat("GSM Display Specifications : Height - {0} , Width - {1} , Number of Colors - {2}",
                            this.display.Height, this.display.Width, this.display.NumberOfColors);
            stringCreator.AppendLine();
            stringCreator.AppendLine(new string('-', 110));

            return stringCreator.ToString();
        }
    }
}
