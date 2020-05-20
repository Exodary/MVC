using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
   public class GSMTest
    {
        public void GsmTesting() { 
        GSM instance1 = new GSM("Nokia", "Connecting People",
            new Battery("BestBatteryEVER", Battery.Type.AlienTech, 1000, 10000), 
            new Display(1000, 1000, 16000000), 
            140000, "HappyOwner");

        GSM instance2 = new GSM("Kia", "Thailand", 
            new Battery("Pesho", Battery.Type.NiCd), 
            new Display(), 100, "Az");

        GSM instance3 = new GSM("Somebrand", "SomeManufacturer",  
            new Battery("Gringo", Battery.Type.AlienTech), 
            new Display(), 100, "Az");

        GSM[] Gsms = new GSM[] { instance1, instance2, instance3 };

        foreach(var gsm in Gsms)
            {
                Console.WriteLine(gsm);
            }


            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
