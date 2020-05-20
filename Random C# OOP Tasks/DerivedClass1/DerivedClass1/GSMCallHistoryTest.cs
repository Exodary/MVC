using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
    public class GSMCallHistoryTest
    {
        public void GSMCallHistoryTesting()
        {
            // Create an instance of the GSM class.
            GSM testGsm = new GSM("Nokia", "Connecting People",
            new Battery("BestBatteryEVER", Battery.Type.AlienTech, 1000, 10000),
            new Display(1000, 1000, 16000000),
            140000, "HappyOwner");

            // Add few calls.
            testGsm.AddCall("+359873432142", 53);
            testGsm.AddCall("+359811432142", 123);
            testGsm.AddCall("+359872412142", 41);
            testGsm.AddCall("+359833332142", 72);
            testGsm.AddCall("+359614432142", 231);

            // Display the information about the calls.
            testGsm.ShowCallHistory();

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Total call price: " + testGsm.CalculateTotalPrice());

            //  Remove the longest call from the history and calculate the total price again.
            testGsm.DeleteCall(4);
            Console.WriteLine("Removed Longest call!");
            Console.WriteLine("Total call price: " + testGsm.CalculateTotalPrice());

            // Clear the call history and print it.
            testGsm.ClearHistory();
            Console.WriteLine("Cleared call history!");
            testGsm.ShowCallHistory();
        }
    }
}
