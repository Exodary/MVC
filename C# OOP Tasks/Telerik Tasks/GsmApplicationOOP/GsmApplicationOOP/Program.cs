using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmApplicationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM firstPhone = new GSM("Nokia", "Connecting People", 140000, "HappyOwner",
                new Battery("BestBatteryEVER", 1000, 10000, Battery.Type.NiMH), new Display(1000, 16000000));

           /* GSM secondPhone = new GSM("Sony", "Simply The Best", 140000, "Me",
                new Battery("BestBattery", 1000, 10000, Battery.Type.NiCd), new Display(1000, 16000000));

            GSM thirdPhone = new GSM("Xiomi", "Mi A1", 140000, "Random",
                new Battery("BatteryEVER", 1000, 10000, Battery.Type.LiIon), new Display(1000, 16000000));

            GSM[] phoneArray = new GSM[] { firstPhone, secondPhone, thirdPhone };

            foreach (var phone in phoneArray)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);*/

            firstPhone.AddCall("0883303626", 20);
            firstPhone.AddCall("0883303621", 10);
            firstPhone.AddCall("0883303622", 50);
            firstPhone.AddCall("0883303623", 40);
            firstPhone.AddCall("0883303624", 17);
            firstPhone.AddCall("0883303625", 79);

            firstPhone.DisplayCallHistory();

            Console.WriteLine("Total call price: " + firstPhone.TotalPriceCost(37));

            firstPhone.DeleteCall(6);
            Console.WriteLine("Longest call deleted!");
            Console.WriteLine("Total call price: " + firstPhone.TotalPriceCost(37));

            firstPhone.DeleteAll();
            firstPhone.DisplayCallHistory();
        }
    }
}
