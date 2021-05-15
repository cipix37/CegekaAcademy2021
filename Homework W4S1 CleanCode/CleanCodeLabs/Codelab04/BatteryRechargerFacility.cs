using System;
using CleanCodeLabs.Codelab04.Interfaces;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class BatteryRechargerFacility
    {
        public static void RechargeBatteriesOf(Worker[] workers)
        {
            foreach (Worker worker in workers)
            {
                if(worker is IRechargeable)
                {
                    Console.WriteLine((worker as IRechargeable).RechargeBatteries());
                }
            }
        }
    }
}