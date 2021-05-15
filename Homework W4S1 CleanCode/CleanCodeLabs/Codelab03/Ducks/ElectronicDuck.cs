using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class ElectronicDuck : Bird
    {
        private bool _isSwitchedOn;

        public override void Quack()
        {
            if (_isSwitchedOn)
            {
                Console.WriteLine("Quack Quack... (in a robot voice)");
            }
        }

        public void TurnOn()
        {
            _isSwitchedOn = true;
        }

        public void TurnOff()
        {
            _isSwitchedOn = false;
        }
    }
}