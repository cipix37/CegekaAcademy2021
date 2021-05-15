using System;
using CleanCodeLabs.Codelab04.Workers;
using CleanCodeLabs.Codelab04.Interfaces;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryHall
    {
        private readonly Worker[] _workers;

        public FactoryHall(Worker[] workers)
        {
            _workers = workers;
        }

        public void StartWorking()
        {
            // WORK
            foreach (IAbleToWork worker in _workers)
            {
                Console.WriteLine(worker.Work());
            }

            // EAT
            new Lunchroom(_workers).StartLunching();

            // RECHARGE BATTERIES
            BatteryRechargerFacility.RechargeBatteriesOf(_workers);
        }
    }
}