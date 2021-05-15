using System;
using CleanCodeLabs.Codelab04.Interfaces;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class Lunchroom
    {
        private readonly Worker[] _lunchers;

        public Lunchroom(Worker[] lunchers)
        {
            _lunchers = lunchers;
        }

        public void StartLunching()
        {
            foreach (Worker luncher in _lunchers)
            {
                if(luncher is IAbleToEat)
                {
                    Console.WriteLine((luncher as IAbleToEat).Eat());
                }
            }
        }
    }
}